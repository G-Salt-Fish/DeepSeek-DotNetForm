using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InputForm : Form
    {

        public string message
        {
            get { return textBox_InputForm.Text; }
            set { textBox_InputForm.Text = value; }
        }

        public string title
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public string input
        {
            get { return textBox_InputForm.Text; }
            set { textBox_InputForm.Text = value; }
        }

        public InputForm()
        {
            InitializeComponent();
        }

        private void button_InputForm_enter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_InputForm_esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
