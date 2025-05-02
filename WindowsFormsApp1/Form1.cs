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
		/// <summary>
		/// 添加颜色文本
		/// </summary>
		/// <param name="rich">富文本框</param>
		/// <param name="text">内容</param>
		/// <param name="color">颜色</param>
		public void AppendColorText(RichTextBox rich,string text,Color color)
		{
			bool onlyRead = rich.ReadOnly;
			rich.ReadOnly = false;
            rich.SelectionStart = rich.TextLength;
            rich.SelectionLength = 0;
            rich.SelectionColor = color;
            rich.AppendText(text);
            rich.SelectionColor = rich.ForeColor; // 恢复默认颜色
            rich.ReadOnly = onlyRead;
            rich.Refresh();
        }

		private DeepSeek deepSeek = new DeepSeek("");

		private string deepSeek_Name = "DeepSeek";
		private Color deepSeek_Color = Color.Blue;

		private string user_Name = "User";
		private Color user_Color = Color.Blue;

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

				AppendColorText(textBox_Talking, user_Name, user_Color);
				textBox_Talking.AppendText(":" + textBox_message.Text + Environment.NewLine);
				try
				{
					var response = await deepSeek.Talk(textBox_message.Text);


					AppendColorText(textBox_Talking, deepSeek_Name, deepSeek_Color);


					textBox_Talking.AppendText(":" + response.Replace("\n", "\r\n") + Environment.NewLine);
				}
				catch (Exception ex)
				{
					textBox_message.ReadOnly = false;
					button_message.Enabled = true;
					MessageBox.Show(ex.Message, "Error");
					return;
				}
				textBox_message.ReadOnly = false;
				textBox_message.Text = string.Empty;
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
			MessageBox.Show("作者：G_Salt_Fish " + Environment.NewLine + "版本：1.0.1.0", "关于");
		}

		private void ToolStripMenuItem_Setting__APIKey_Click(object sender, EventArgs e)
		{
			InputForm inputForm = new InputForm();
			inputForm.message = deepSeek.ShowKey();
			inputForm.title = "API Key";
			inputForm.ShowDialog(this);
			deepSeek.ChangeKey(inputForm.input);
			AppendColorText(textBox_Talking, "API Key", Color.Blue);
			textBox_Talking.AppendText("修改为:" + inputForm.input + Environment.NewLine);
		}

		private void ToolStripMenuItem_Setting__SystemPrompt_Click(object sender, EventArgs e)
		{
			InputForm inputForm = new InputForm();
			inputForm.title = "系统提示词";
			inputForm.message = deepSeek.SystemPrompt;
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
			AppendColorText(textBox_Talking, "系统提示词", Color.Blue);
			textBox_Talking.AppendText("现为:" + inputForm.input + Environment.NewLine);
		}

        private void ToolStripMenuItem_Setting__Salutation_DeepSeek_Click(object sender, EventArgs e)
        {
			InputForm inputForm = new InputForm();
			inputForm.message = deepSeek_Name;
			inputForm.title = "DeepSeek名称";
			inputForm.ShowDialog(this);
			string temp = string.Empty;
			string old = deepSeek_Name;
			temp = inputForm.input;
			if (!string.IsNullOrWhiteSpace(temp))
			{
				deepSeek_Name = temp;
				AppendColorText(textBox_Talking, "DeepSeek名称", Color.Blue);
				textBox_Talking.AppendText("修改为:");
				AppendColorText(textBox_Talking, deepSeek_Name, Color.Blue);
				textBox_Talking.AppendText(Environment.NewLine);
			}
			else
			{
				MessageBox.Show("名称不能为空！", "Error");
				deepSeek_Name = old;
				ToolStripMenuItem_Setting__Salutation_DeepSeek_Click(sender, e);
			}
        }

        private void ToolStripMenuItem_Setting__Salutation_User_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            inputForm.message = user_Name;
            inputForm.title = "User名称";
            inputForm.ShowDialog(this);
			string temp = string.Empty;
			string old = user_Name;
			temp = inputForm.input;
            if(!string.IsNullOrWhiteSpace(temp))
			{
				user_Name = temp;
                AppendColorText(textBox_Talking, "User名称", Color.Blue);
                textBox_Talking.AppendText("修改为:");
                AppendColorText(textBox_Talking, user_Name, Color.Blue);
                textBox_Talking.AppendText(Environment.NewLine);
            }
            else
			{
                MessageBox.Show("名称不能为空！", "Error");
                user_Name = old;
				ToolStripMenuItem_Setting__Salutation_User_Click(sender, e);

            } 
        }

        private void ToolStripMenuItem_Setting__Color_DeepSeek_Click(object sender, EventArgs e)
        {
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.Color = deepSeek_Color;
			colorDialog.ShowHelp = true;
            colorDialog.AllowFullOpen = true;
            colorDialog.ShowDialog();
            deepSeek_Color = colorDialog.Color;
            AppendColorText(textBox_Talking, "DeepSeek颜色", Color.Blue);
            textBox_Talking.AppendText("修改为:");
            AppendColorText(textBox_Talking, deepSeek_Name, deepSeek_Color);
            textBox_Talking.AppendText(Environment.NewLine);
        }

        private void ToolStripMenuItem_Setting__Color_User_Click(object sender, EventArgs e)
        {
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.Color = user_Color;
			colorDialog.ShowHelp = true;
            colorDialog.AllowFullOpen = true;
            colorDialog.ShowDialog();
            user_Color = colorDialog.Color;
            AppendColorText(textBox_Talking, "User颜色", Color.Blue);
            textBox_Talking.AppendText("修改为:");
            AppendColorText(textBox_Talking, user_Name, user_Color);
            textBox_Talking.AppendText(Environment.NewLine);
        }
    }
}
