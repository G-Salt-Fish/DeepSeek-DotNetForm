using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

	public partial class Form1 : Form
	{
		private DeepSeek deepSeek = new DeepSeek("");

        public string API_KEY 
        {
            get { return deepSeek.ShowKey(); }
            set { deepSeek.ChangeKey(value.ToString()); }
        }

		public Form1()
		{
			InitializeComponent();
		}

        private async void Button_message_Click(object sender, EventArgs e)
		{
			if(!deepSeek.IsTalking)
			{
                button_message.Enabled = false;
                textBox_Talking.Text += Environment.NewLine + "User:" + textBox_message.Text;
                try
                {
                    var response = await deepSeek.Talk(textBox_message.Text);
                    textBox_Talking.Text += Environment.NewLine + "DeepSeek:" + response.Replace("\n","\r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    return;
                }
                textBox_message.ReadOnly = false;
                textBox_message.Text = "";
                button_message.Enabled = true;
            }
		}

        private void TextBox_message_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Button_message_Click(sender, e);
                textBox_message.ReadOnly = true;
            }
        }

      

        private void ToolStripMenuItem_Setting__About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者：G_Salt_Fish " + Environment.NewLine + "版本：Beta-1.0", "关于");
        }

        private void ToolStripMenuItem_Setting__APIKey_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            inputForm.message = deepSeek.ShowKey();
            inputForm.title = "API Key:";
            inputForm.ShowDialog(this);
            deepSeek.ChangeKey(inputForm.input);
            textBox_Talking.Text += Environment.NewLine + "API Key修改为:" + inputForm.input;
        }

        private void ToolStripMenuItem_Setting__SystemPrompt_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            inputForm.ShowDialog(this);
            try
            {
                deepSeek.SystemPrompt = inputForm.input;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }
            textBox_Talking.Text += Environment.NewLine + "系统提示词现为:" + inputForm.input;
        }
        
    }
}
