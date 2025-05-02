namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.button_message = new System.Windows.Forms.Button();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.label_message = new System.Windows.Forms.Label();
            this.Form1_menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Setting__APIKey = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Setting__SystemPrompt = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Setting__About = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_Talking = new System.Windows.Forms.RichTextBox();
            this.ToolStripMenuItem_Setting__Salutation = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Setting__Salutation_DeepSeek = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Setting__Salutation_User = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Setting__Color = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Setting__Color_DeepSeek = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Setting__Color_User = new System.Windows.Forms.ToolStripMenuItem();
            this.Form1_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_message
            // 
            this.button_message.Location = new System.Drawing.Point(697, 498);
            this.button_message.Name = "button_message";
            this.button_message.Size = new System.Drawing.Size(75, 23);
            this.button_message.TabIndex = 3;
            this.button_message.Text = "确认";
            this.button_message.UseVisualStyleBackColor = true;
            this.button_message.Click += new System.EventHandler(this.Button_message_Click);
            // 
            // textBox_message
            // 
            this.textBox_message.AllowDrop = true;
            this.textBox_message.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_message.Location = new System.Drawing.Point(81, 459);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_message.Size = new System.Drawing.Size(610, 90);
            this.textBox_message.TabIndex = 4;
            this.textBox_message.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_message_KeyPress);
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Location = new System.Drawing.Point(12, 498);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(63, 17);
            this.label_message.TabIndex = 5;
            this.label_message.Text = "message:";
            // 
            // Form1_menuStrip
            // 
            this.Form1_menuStrip.BackColor = System.Drawing.SystemColors.Menu;
            this.Form1_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Setting});
            this.Form1_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.Form1_menuStrip.Name = "Form1_menuStrip";
            this.Form1_menuStrip.Size = new System.Drawing.Size(784, 25);
            this.Form1_menuStrip.TabIndex = 6;
            this.Form1_menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Setting
            // 
            this.ToolStripMenuItem_Setting.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolStripMenuItem_Setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Setting__APIKey,
            this.ToolStripMenuItem_Setting__SystemPrompt,
            this.ToolStripMenuItem_Setting__Salutation,
            this.ToolStripMenuItem_Setting__Color,
            this.ToolStripMenuItem_Setting__About});
            this.ToolStripMenuItem_Setting.Name = "ToolStripMenuItem_Setting";
            this.ToolStripMenuItem_Setting.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItem_Setting.Text = "设置";
            // 
            // ToolStripMenuItem_Setting__APIKey
            // 
            this.ToolStripMenuItem_Setting__APIKey.Name = "ToolStripMenuItem_Setting__APIKey";
            this.ToolStripMenuItem_Setting__APIKey.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Setting__APIKey.Text = "API Key";
            this.ToolStripMenuItem_Setting__APIKey.Click += new System.EventHandler(this.ToolStripMenuItem_Setting__APIKey_Click);
            // 
            // ToolStripMenuItem_Setting__SystemPrompt
            // 
            this.ToolStripMenuItem_Setting__SystemPrompt.Name = "ToolStripMenuItem_Setting__SystemPrompt";
            this.ToolStripMenuItem_Setting__SystemPrompt.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Setting__SystemPrompt.Text = "系统提示词";
            this.ToolStripMenuItem_Setting__SystemPrompt.Click += new System.EventHandler(this.ToolStripMenuItem_Setting__SystemPrompt_Click);
            // 
            // ToolStripMenuItem_Setting__About
            // 
            this.ToolStripMenuItem_Setting__About.Name = "ToolStripMenuItem_Setting__About";
            this.ToolStripMenuItem_Setting__About.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Setting__About.Text = "关于";
            this.ToolStripMenuItem_Setting__About.Click += new System.EventHandler(this.ToolStripMenuItem_Setting__About_Click);
            // 
            // textBox_Talking
            // 
            this.textBox_Talking.Location = new System.Drawing.Point(12, 28);
            this.textBox_Talking.Name = "textBox_Talking";
            this.textBox_Talking.ReadOnly = true;
            this.textBox_Talking.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.textBox_Talking.Size = new System.Drawing.Size(760, 425);
            this.textBox_Talking.TabIndex = 7;
            this.textBox_Talking.Text = "";
            // 
            // ToolStripMenuItem_Setting__Salutation
            // 
            this.ToolStripMenuItem_Setting__Salutation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Setting__Salutation_DeepSeek,
            this.ToolStripMenuItem_Setting__Salutation_User});
            this.ToolStripMenuItem_Setting__Salutation.Name = "ToolStripMenuItem_Setting__Salutation";
            this.ToolStripMenuItem_Setting__Salutation.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Setting__Salutation.Text = "称呼";
            // 
            // ToolStripMenuItem_Setting__Salutation_DeepSeek
            // 
            this.ToolStripMenuItem_Setting__Salutation_DeepSeek.Name = "ToolStripMenuItem_Setting__Salutation_DeepSeek";
            this.ToolStripMenuItem_Setting__Salutation_DeepSeek.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Setting__Salutation_DeepSeek.Text = "DeepSeek";
            this.ToolStripMenuItem_Setting__Salutation_DeepSeek.Click += new System.EventHandler(this.ToolStripMenuItem_Setting__Salutation_DeepSeek_Click);
            // 
            // ToolStripMenuItem_Setting__Salutation_User
            // 
            this.ToolStripMenuItem_Setting__Salutation_User.Name = "ToolStripMenuItem_Setting__Salutation_User";
            this.ToolStripMenuItem_Setting__Salutation_User.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Setting__Salutation_User.Text = "User";
            this.ToolStripMenuItem_Setting__Salutation_User.Click += new System.EventHandler(this.ToolStripMenuItem_Setting__Salutation_User_Click);
            // 
            // ToolStripMenuItem_Setting__Color
            // 
            this.ToolStripMenuItem_Setting__Color.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Setting__Color_DeepSeek,
            this.ToolStripMenuItem_Setting__Color_User});
            this.ToolStripMenuItem_Setting__Color.Name = "ToolStripMenuItem_Setting__Color";
            this.ToolStripMenuItem_Setting__Color.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Setting__Color.Text = "颜色";
            // 
            // ToolStripMenuItem_Setting__Color_DeepSeek
            // 
            this.ToolStripMenuItem_Setting__Color_DeepSeek.Name = "ToolStripMenuItem_Setting__Color_DeepSeek";
            this.ToolStripMenuItem_Setting__Color_DeepSeek.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Setting__Color_DeepSeek.Text = "DeepSeek";
            this.ToolStripMenuItem_Setting__Color_DeepSeek.Click += new System.EventHandler(this.ToolStripMenuItem_Setting__Color_DeepSeek_Click);
            // 
            // ToolStripMenuItem_Setting__Color_User
            // 
            this.ToolStripMenuItem_Setting__Color_User.Name = "ToolStripMenuItem_Setting__Color_User";
            this.ToolStripMenuItem_Setting__Color_User.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Setting__Color_User.Text = "User";
            this.ToolStripMenuItem_Setting__Color_User.Click += new System.EventHandler(this.ToolStripMenuItem_Setting__Color_User_Click);
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.textBox_Talking);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.button_message);
            this.Controls.Add(this.Form1_menuStrip);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.Form1_menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.Form1_menuStrip.ResumeLayout(false);
            this.Form1_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button_message;
		private System.Windows.Forms.TextBox textBox_message;
		private System.Windows.Forms.Label label_message;
		private System.Windows.Forms.MenuStrip Form1_menuStrip;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Setting;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Setting__About;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Setting__APIKey;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Setting__SystemPrompt;
        private System.Windows.Forms.RichTextBox textBox_Talking;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Setting__Salutation;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Setting__Salutation_DeepSeek;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Setting__Salutation_User;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Setting__Color;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Setting__Color_DeepSeek;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Setting__Color_User;
    }
}

