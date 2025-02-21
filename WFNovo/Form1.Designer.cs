namespace WFNovo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsername = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnLogar = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(23, 30);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(92, 27);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(92, 69);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(23, 72);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(117, 122);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(75, 23);
            btnLogar.TabIndex = 4;
            btnLogar.Text = "Login";
            btnLogar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 166);
            Controls.Add(btnLogar);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUsername);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnLogar;
    }
}
