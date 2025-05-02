namespace WindowsFormsApp1
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
        private void InitializeComponent()
        {
            this.textBox_InputForm = new System.Windows.Forms.TextBox();
            this.button_InputForm_esc = new System.Windows.Forms.Button();
            this.button_InputForm_enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_InputForm
            // 
            this.textBox_InputForm.AllowDrop = true;
            this.textBox_InputForm.Location = new System.Drawing.Point(12, 12);
            this.textBox_InputForm.Multiline = true;
            this.textBox_InputForm.Name = "textBox_InputForm";
            this.textBox_InputForm.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_InputForm.Size = new System.Drawing.Size(360, 108);
            this.textBox_InputForm.TabIndex = 0;
            // 
            // button_InputForm_esc
            // 
            this.button_InputForm_esc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_InputForm_esc.Location = new System.Drawing.Point(297, 126);
            this.button_InputForm_esc.Name = "button_InputForm_esc";
            this.button_InputForm_esc.Size = new System.Drawing.Size(75, 23);
            this.button_InputForm_esc.TabIndex = 1;
            this.button_InputForm_esc.Text = "取消";
            this.button_InputForm_esc.UseVisualStyleBackColor = true;
            this.button_InputForm_esc.Click += new System.EventHandler(this.button_InputForm_esc_Click);
            // 
            // button_InputForm_enter
            // 
            this.button_InputForm_enter.Location = new System.Drawing.Point(216, 126);
            this.button_InputForm_enter.Name = "button_InputForm_enter";
            this.button_InputForm_enter.Size = new System.Drawing.Size(75, 23);
            this.button_InputForm_enter.TabIndex = 2;
            this.button_InputForm_enter.Text = "确认";
            this.button_InputForm_enter.UseVisualStyleBackColor = true;
            this.button_InputForm_enter.Click += new System.EventHandler(this.button_InputForm_enter_Click);
            // 
            // InputForm
            // 
            this.AcceptButton = this.button_InputForm_enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.button_InputForm_esc;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.button_InputForm_enter);
            this.Controls.Add(this.button_InputForm_esc);
            this.Controls.Add(this.textBox_InputForm);
            this.MaximizeBox = false;
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_InputForm;
        private System.Windows.Forms.Button button_InputForm_esc;
        private System.Windows.Forms.Button button_InputForm_enter;
    }
}