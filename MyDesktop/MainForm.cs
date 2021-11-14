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
    }
}
