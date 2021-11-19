using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDesktop.UserControls
{
    public partial class MyControl : UserControl
    {
        public Label LabelText
        {
            get { return this.label1; }
            set { this.label1 = value; }
        }

        public TextBox TextBoxText
        {
            get { return this.textBox1; }
            set { this.textBox1 = value; }
        }

        public string Text
        {
            get { return this.textBox1.Text; }
            set { this.textBox1.Text = value; }
        }

        public string Label
        {
            get { return this.label1.Text; }
            set { this.label1.Text = value; }
        }

        public MyControl()
        {
            InitializeComponent();
        }
    }
}
