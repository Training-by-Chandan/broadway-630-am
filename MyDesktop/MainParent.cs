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
    public partial class MainParent : Form
    {
        public MainParent()
        {
            InitializeComponent();
        }

        private void MainParent_Load(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void OpenLoginForm()
        {
            Login l = new Login();
            l.MdiParent = this;
            l.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //todo all the other forms should close
            CloseAllExistingForms();

            //and login form should open
            OpenLoginForm();
        }

        private void CloseAllExistingForms()
        {
        }
    }
}
