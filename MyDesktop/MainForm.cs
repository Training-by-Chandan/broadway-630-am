using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDesktop
{
    public partial class MainForm : Form
    {
        private Data.DefaultContext db = new Data.DefaultContext();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            var data = db.Students.ToList();
            GridStudent.DataSource = data;
            GridStudent.Refresh();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                InsertData();
                RefreshData();
                ClearData();
            }
            else
            {
                MessageBox.Show("There are some errors");
            }
        }

        private bool Validation()
        {
            var res = true;

            if (TextFirstName.Text == string.Empty)
            {
                LabelFirstName.ForeColor = Color.Red;
                res = false;
            }
            else
            {
                LabelFirstName.ForeColor = Color.Black;
            }

            if (TextLastName.Text == string.Empty)
            {
                LabelLastName.ForeColor = Color.Red;
                res = false;
            }
            else
            {
                LabelLastName.ForeColor = Color.Black;
            }
            return res;
        }

        private void ClearData()
        {
            TextFirstName.Text = string.Empty;
            TextLastName.Text = string.Empty;
            DateDob.Value = DateTime.Now;
        }

        private void InsertData()
        {
            var student = new Model.Student()
            {
                FirstName = TextFirstName.Text,
                LastName = TextLastName.Text,
                DOB = DateDob.Value
            };
            db.Students.Add(student);
            db.SaveChanges();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void GridStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (GridStudent.SelectedRows.Count > 0)
            {
                var rows = GridStudent.SelectedRows[0];
                TextFirstName.Text = rows.Cells[1].Value.ToString();
                TextLastName.Text = rows.Cells[2].Value.ToString();
                DateDob.Value = DateTime.Parse(rows.Cells[3].Value.ToString());

                //to enable edit and delete button
                BtnEdit.Visible = true;
                BtnDelete.Visible = true;
            }
            else
            {
                DisableEditAndDelete();
            }
        }

        private void DisableEditAndDelete()
        {
            TextFirstName.Text = string.Empty;
            TextLastName.Text = string.Empty;
            DateDob.Value = DateTime.Now;

            //to enable edit and delete button
            BtnEdit.Visible = false;
            BtnDelete.Visible = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void Edit()
        {
            var id = Convert.ToInt32(GridStudent.SelectedRows[0].Cells[0].Value);
            var student = db.Students.Find(id);
            if (student != null)
            {
                student.FirstName = TextFirstName.Text;
                student.LastName = TextLastName.Text;
                student.DOB = DateDob.Value;
                db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                DisableEditAndDelete();
                RefreshData();
            }
        }

        private void Delete()
        {
            var id = Convert.ToInt32(GridStudent.SelectedRows[0].Cells[0].Value);
            var student = db.Students.Find(id);
            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
                DisableEditAndDelete();
                RefreshData();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to delete this record?", "Danger", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Delete();
            }
        }
    }
}
