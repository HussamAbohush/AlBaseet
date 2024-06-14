namespace AlBaseet.Winform
{
    partial class LoginForm
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
            pnlLogin = new Panel();
            btnResetPassword2 = new LinkLabel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            linPassword = new Panel();
            linUsername = new Panel();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            ExitButton = new Button();
            backButton = new Button();
            resetPasswordPanel = new Panel();
            resetButton = new Button();
            newPasswordPanel = new Panel();
            saveNewPasswordButton = new Button();
            label2 = new Label();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            resetPasswordPanel.SuspendLayout();
            newPasswordPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(btnResetPassword2);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(pictureBox2);
            pnlLogin.Controls.Add(pictureBox1);
            pnlLogin.Controls.Add(linPassword);
            pnlLogin.Controls.Add(linUsername);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Location = new Point(0, 50);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(300, 450);
            pnlLogin.TabIndex = 0;
            pnlLogin.TabStop = true;
            // 
            // btnResetPassword2
            // 
            btnResetPassword2.ActiveLinkColor = Color.MidnightBlue;
            btnResetPassword2.AutoSize = true;
            btnResetPassword2.Location = new Point(40, 254);
            btnResetPassword2.Name = "btnResetPassword2";
            btnResetPassword2.Size = new Size(126, 15);
            btnResetPassword2.TabIndex = 11;
            btnResetPassword2.TabStop = true;
            btnResetPassword2.Text = "Forget Your Password?";
            btnResetPassword2.LinkClicked += btnResetPassword2_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 368);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 10;
            label1.Text = "If you dont have an Account ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.LoginUser;
            pictureBox2.Location = new Point(40, 174);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 16);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LoginScreen;
            pictureBox1.Location = new Point(40, 225);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 16);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // linPassword
            // 
            linPassword.Anchor = AnchorStyles.None;
            linPassword.BackColor = SystemColors.Highlight;
            linPassword.Location = new Point(35, 250);
            linPassword.Name = "linPassword";
            linPassword.Size = new Size(230, 1);
            linPassword.TabIndex = 6;
            // 
            // linUsername
            // 
            linUsername.Anchor = AnchorStyles.None;
            linUsername.BackColor = SystemColors.Highlight;
            linUsername.Location = new Point(35, 200);
            linUsername.Name = "linUsername";
            linUsername.Size = new Size(236, 1);
            linUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = SystemColors.WindowFrame;
            txtPassword.Location = new Point(70, 225);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 16);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.ForeColor = SystemColors.WindowFrame;
            txtUsername.Location = new Point(70, 175);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 16);
            txtUsername.TabIndex = 3;
            txtUsername.Text = "UserName";
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(35, 300);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(230, 35);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += loginButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Image = Properties.Resources.Close;
            ExitButton.Location = new Point(267, 10);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(30, 30);
            ExitButton.TabIndex = 0;
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // backButton
            // 
            backButton.Cursor = Cursors.Hand;
            backButton.Image = Properties.Resources.CollapseLeft;
            backButton.Location = new Point(13, 10);
            backButton.Name = "backButton";
            backButton.Size = new Size(30, 30);
            backButton.TabIndex = 0;
            backButton.UseVisualStyleBackColor = true;
            backButton.Visible = false;
            backButton.Click += backButton_Click;
            // 
            // resetPasswordPanel
            // 
            resetPasswordPanel.Controls.Add(resetButton);
            resetPasswordPanel.Location = new Point(0, 50);
            resetPasswordPanel.Name = "resetPasswordPanel";
            resetPasswordPanel.Size = new Size(300, 450);
            resetPasswordPanel.TabIndex = 1;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(35, 300);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(230, 35);
            resetButton.TabIndex = 2;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // newPasswordPanel
            // 
            newPasswordPanel.Controls.Add(saveNewPasswordButton);
            newPasswordPanel.Location = new Point(0, 50);
            newPasswordPanel.Name = "newPasswordPanel";
            newPasswordPanel.Size = new Size(300, 450);
            newPasswordPanel.TabIndex = 1;
            // 
            // saveNewPasswordButton
            // 
            saveNewPasswordButton.Location = new Point(35, 300);
            saveNewPasswordButton.Name = "saveNewPasswordButton";
            saveNewPasswordButton.Size = new Size(230, 35);
            saveNewPasswordButton.TabIndex = 2;
            saveNewPasswordButton.Text = "Save";
            saveNewPasswordButton.UseVisualStyleBackColor = true;
            saveNewPasswordButton.Click += saveNewPasswordButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 383);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 12;
            label2.Text = "please contact your manager ";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 500);
            Controls.Add(backButton);
            Controls.Add(ExitButton);
            Controls.Add(pnlLogin);
            Controls.Add(resetPasswordPanel);
            Controls.Add(newPasswordPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            resetPasswordPanel.ResumeLayout(false);
            newPasswordPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Button ExitButton;
        private Button backButton;
        private Panel newPasswordPanel;
        private Panel resetPasswordPanel;
        private Button btnLogin;
        private Button saveNewPasswordButton;
        private Button resetButton;
        private Panel linUsername;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Panel linPassword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private LinkLabel btnResetPassword2;
        private Label label2;
    }
}
