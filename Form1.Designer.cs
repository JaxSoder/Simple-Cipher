namespace JaxsCipher
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputCipherText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputCipherText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.InputDecipherText = new System.Windows.Forms.TextBox();
            this.OutputDecipherText = new System.Windows.Forms.TextBox();
            this.DecipherBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NotWorkingBtn = new System.Windows.Forms.Button();
            this.GithubLink = new System.Windows.Forms.LinkLabel();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputCipherText
            // 
            this.InputCipherText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.InputCipherText.Location = new System.Drawing.Point(17, 62);
            this.InputCipherText.Multiline = true;
            this.InputCipherText.Name = "InputCipherText";
            this.InputCipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputCipherText.Size = new System.Drawing.Size(241, 149);
            this.InputCipherText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jaxs Cipher";
            // 
            // OutputCipherText
            // 
            this.OutputCipherText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OutputCipherText.Location = new System.Drawing.Point(436, 62);
            this.OutputCipherText.Multiline = true;
            this.OutputCipherText.Name = "OutputCipherText";
            this.OutputCipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputCipherText.Size = new System.Drawing.Size(241, 149);
            this.OutputCipherText.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cipher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputDecipherText
            // 
            this.InputDecipherText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.InputDecipherText.Location = new System.Drawing.Point(17, 258);
            this.InputDecipherText.Multiline = true;
            this.InputDecipherText.Name = "InputDecipherText";
            this.InputDecipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputDecipherText.Size = new System.Drawing.Size(241, 149);
            this.InputDecipherText.TabIndex = 5;
            // 
            // OutputDecipherText
            // 
            this.OutputDecipherText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OutputDecipherText.Location = new System.Drawing.Point(436, 258);
            this.OutputDecipherText.Multiline = true;
            this.OutputDecipherText.Name = "OutputDecipherText";
            this.OutputDecipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputDecipherText.Size = new System.Drawing.Size(241, 149);
            this.OutputDecipherText.TabIndex = 6;
            // 
            // DecipherBtn
            // 
            this.DecipherBtn.Location = new System.Drawing.Point(183, 413);
            this.DecipherBtn.Name = "DecipherBtn";
            this.DecipherBtn.Size = new System.Drawing.Size(75, 23);
            this.DecipherBtn.TabIndex = 7;
            this.DecipherBtn.Text = "Decipher";
            this.DecipherBtn.UseVisualStyleBackColor = true;
            this.DecipherBtn.Click += new System.EventHandler(this.DecipherBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Output";
            // 
            // NotWorkingBtn
            // 
            this.NotWorkingBtn.Location = new System.Drawing.Point(593, 415);
            this.NotWorkingBtn.Name = "NotWorkingBtn";
            this.NotWorkingBtn.Size = new System.Drawing.Size(84, 23);
            this.NotWorkingBtn.TabIndex = 10;
            this.NotWorkingBtn.Text = "Not Working?";
            this.NotWorkingBtn.UseVisualStyleBackColor = true;
            this.NotWorkingBtn.Click += new System.EventHandler(this.NotWorkingBtn_Click);
            // 
            // GithubLink
            // 
            this.GithubLink.AutoSize = true;
            this.GithubLink.Location = new System.Drawing.Point(540, 423);
            this.GithubLink.Name = "GithubLink";
            this.GithubLink.Size = new System.Drawing.Size(38, 13);
            this.GithubLink.TabIndex = 11;
            this.GithubLink.TabStop = true;
            this.GithubLink.Text = "Github";
            this.GithubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLink_LinkClicked);
            // 
            // CopyBtn
            // 
            this.CopyBtn.Location = new System.Drawing.Point(661, 36);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(16, 23);
            this.CopyBtn.TabIndex = 12;
            this.CopyBtn.Text = "C";
            this.CopyBtn.UseVisualStyleBackColor = true;
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.GithubLink);
            this.Controls.Add(this.NotWorkingBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DecipherBtn);
            this.Controls.Add(this.OutputDecipherText);
            this.Controls.Add(this.InputDecipherText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OutputCipherText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputCipherText);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Jaxs_Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputCipherText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputCipherText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox InputDecipherText;
        private System.Windows.Forms.TextBox OutputDecipherText;
        private System.Windows.Forms.Button DecipherBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NotWorkingBtn;
        private System.Windows.Forms.LinkLabel GithubLink;
        private System.Windows.Forms.Button CopyBtn;
    }
}

