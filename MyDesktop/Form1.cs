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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Click += new System.EventHandler(this.Form1_Click);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Form is clicked");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateAndLoanDummyData();
            // MessageBox.Show("Form is loaded");
        }

        private int i = 0;

        private void mainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
        }

        private int id = 5;

        private void button1_Click(object sender, EventArgs e)
        {
            id++;
            t.Add(new Student()
            {
                Id = id,
                Name = TextName.Text
            });
            
        }

        private List<Student> t = new List<Student>() {
            new Student(){Id=1,Name="Chandan" },
            new Student(){Id=2,Name= "Pratik" },
            new Student(){Id=3,Name= "Ruman" },
            new Student(){Id=4,Name= "Bashanta" },
            new Student(){Id=5,Name= "Kishor" }
        };

        private void GenerateAndLoanDummyData()
        {
            GridSomeData.DataSource = t;
            GridSomeData.Refresh();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
