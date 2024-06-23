namespace AlBaseet.Winform.Forms;

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
        lblLoginError = new Label();
        chkShowPassword = new CheckBox();
        txtPassword = new Controls.TextBoxGroup();
        txtUsername = new Controls.TextBoxGroup();
        label2 = new Label();
        btnResetPassword = new LinkLabel();
        label1 = new Label();
        btnLogin = new Button();
        btnExit = new Button();
        btnBack = new Button();
        pnlResetPassword = new Panel();
        lblResetError = new Label();
        txtUsernameforReset = new Controls.TextBoxGroup();
        txtRecoveryPhrase = new Controls.TextBoxGroup();
        btnReset = new Button();
        pnlNewPassword = new Panel();
        lblChangeError = new Label();
        chkShowNewPassword = new CheckBox();
        txtConfirmPassword = new Controls.TextBoxGroup();
        txtNewPassword = new Controls.TextBoxGroup();
        btnSavePassword = new Button();
        pictureBox1 = new PictureBox();
        pnlLogin.SuspendLayout();
        pnlResetPassword.SuspendLayout();
        pnlNewPassword.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pnlLogin
        // 
        pnlLogin.Controls.Add(lblLoginError);
        pnlLogin.Controls.Add(chkShowPassword);
        pnlLogin.Controls.Add(txtPassword);
        pnlLogin.Controls.Add(txtUsername);
        pnlLogin.Controls.Add(label2);
        pnlLogin.Controls.Add(btnResetPassword);
        pnlLogin.Controls.Add(label1);
        pnlLogin.Controls.Add(btnLogin);
        pnlLogin.Location = new Point(0, 200);
        pnlLogin.Name = "pnlLogin";
        pnlLogin.Size = new Size(300, 300);
        pnlLogin.TabIndex = 0;
        pnlLogin.TabStop = true;
        // 
        // lblLoginError
        // 
        lblLoginError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblLoginError.ForeColor = Color.Tomato;
        lblLoginError.Location = new Point(35, 15);
        lblLoginError.Name = "lblLoginError";
        lblLoginError.Size = new Size(230, 15);
        lblLoginError.TabIndex = 16;
        lblLoginError.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // chkShowPassword
        // 
        chkShowPassword.AutoSize = true;
        chkShowPassword.Location = new Point(42, 130);
        chkShowPassword.Name = "chkShowPassword";
        chkShowPassword.Size = new Size(108, 19);
        chkShowPassword.TabIndex = 2;
        chkShowPassword.Text = "Show Password";
        chkShowPassword.UseVisualStyleBackColor = true;
        chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
        // 
        // txtPassword
        // 
        txtPassword.Image = WinForm.Properties.Resources.LoginScreen;
        txtPassword.isPassword = true;
        txtPassword.Location = new Point(25, 90);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(250, 30);
        txtPassword.TabIndex = 1;
        txtPassword.Text = "Password";
        // 
        // txtUsername
        // 
        txtUsername.Image = WinForm.Properties.Resources.LoginUser;
        txtUsername.isPassword = false;
        txtUsername.Location = new Point(25, 40);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(250, 30);
        txtUsername.TabIndex = 0;
        txtUsername.Text = "Username";
        // 
        // label2
        // 
        label2.Location = new Point(85, 265);
        label2.Name = "label2";
        label2.Size = new Size(130, 15);
        label2.TabIndex = 15;
        label2.Text = " Contact your manager ";
        label2.Visible = false;
        // 
        // btnResetPassword
        // 
        btnResetPassword.ActiveLinkColor = Color.MidnightBlue;
        btnResetPassword.AutoSize = true;
        btnResetPassword.Location = new Point(65, 220);
        btnResetPassword.Name = "btnResetPassword";
        btnResetPassword.Size = new Size(170, 15);
        btnResetPassword.TabIndex = 4;
        btnResetPassword.TabStop = true;
        btnResetPassword.Text = "Did You Forget Your Password?";
        btnResetPassword.LinkClicked += btnResetPassword_LinkClicked;
        // 
        // label1
        // 
        label1.Location = new Point(35, 248);
        label1.Name = "label1";
        label1.Size = new Size(235, 15);
        label1.TabIndex = 14;
        label1.Text = "If you need an Account or Recovery Phrase";
        label1.Visible = false;
        // 
        // btnLogin
        // 
        btnLogin.Cursor = Cursors.Hand;
        btnLogin.Location = new Point(35, 165);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(230, 35);
        btnLogin.TabIndex = 3;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += loginButton_Click;
        // 
        // btnExit
        // 
        btnExit.Cursor = Cursors.Hand;
        btnExit.Image = WinForm.Properties.Resources.Close;
        btnExit.Location = new Point(255, 10);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(30, 30);
        btnExit.TabIndex = 12;
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += ExitButton_Click;
        // 
        // btnBack
        // 
        btnBack.Cursor = Cursors.Hand;
        btnBack.Image = WinForm.Properties.Resources.CollapseLeft;
        btnBack.Location = new Point(15, 10);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(30, 30);
        btnBack.TabIndex = 13;
        btnBack.UseVisualStyleBackColor = true;
        btnBack.Visible = false;
        btnBack.Click += backButton_Click;
        // 
        // pnlResetPassword
        // 
        pnlResetPassword.Controls.Add(lblResetError);
        pnlResetPassword.Controls.Add(txtUsernameforReset);
        pnlResetPassword.Controls.Add(txtRecoveryPhrase);
        pnlResetPassword.Controls.Add(btnReset);
        pnlResetPassword.Location = new Point(0, 200);
        pnlResetPassword.Name = "pnlResetPassword";
        pnlResetPassword.Size = new Size(300, 300);
        pnlResetPassword.TabIndex = 1;
        pnlResetPassword.Visible = false;
        // 
        // lblResetError
        // 
        lblResetError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        lblResetError.ForeColor = Color.Tomato;
        lblResetError.Location = new Point(35, 15);
        lblResetError.Name = "lblResetError";
        lblResetError.Size = new Size(230, 15);
        lblResetError.TabIndex = 18;
        lblResetError.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtUsernameforReset
        // 
        txtUsernameforReset.Image = WinForm.Properties.Resources.LoginUser;
        txtUsernameforReset.isPassword = false;
        txtUsernameforReset.Location = new Point(25, 40);
        txtUsernameforReset.Name = "txtUsernameforReset";
        txtUsernameforReset.Size = new Size(250, 30);
        txtUsernameforReset.TabIndex = 5;
        txtUsernameforReset.Text = "Username";
        // 
        // txtRecoveryPhrase
        // 
        txtRecoveryPhrase.Image = WinForm.Properties.Resources.LoginScreen;
        txtRecoveryPhrase.isPassword = false;
        txtRecoveryPhrase.Location = new Point(25, 90);
        txtRecoveryPhrase.Name = "txtRecoveryPhrase";
        txtRecoveryPhrase.Size = new Size(250, 30);
        txtRecoveryPhrase.TabIndex = 6;
        txtRecoveryPhrase.Text = "Recovery Phrase";
        // 
        // btnReset
        // 
        btnReset.Location = new Point(35, 165);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(230, 35);
        btnReset.TabIndex = 7;
        btnReset.Text = "Reset";
        btnReset.UseVisualStyleBackColor = true;
        btnReset.Click += resetButton_Click;
        // 
        // pnlNewPassword
        // 
        pnlNewPassword.Controls.Add(lblChangeError);
        pnlNewPassword.Controls.Add(chkShowNewPassword);
        pnlNewPassword.Controls.Add(txtConfirmPassword);
        pnlNewPassword.Controls.Add(txtNewPassword);
        pnlNewPassword.Controls.Add(btnSavePassword);
        pnlNewPassword.Location = new Point(0, 200);
        pnlNewPassword.Name = "pnlNewPassword";
        pnlNewPassword.Size = new Size(300, 300);
        pnlNewPassword.TabIndex = 1;
        pnlNewPassword.Visible = false;
        // 
        // lblChangeError
        // 
        lblChangeError.ForeColor = Color.Tomato;
        lblChangeError.Location = new Point(35, 5);
        lblChangeError.Name = "lblChangeError";
        lblChangeError.Size = new Size(230, 30);
        lblChangeError.TabIndex = 12;
        // 
        // chkShowNewPassword
        // 
        chkShowNewPassword.AutoSize = true;
        chkShowNewPassword.Location = new Point(40, 130);
        chkShowNewPassword.Name = "chkShowNewPassword";
        chkShowNewPassword.Size = new Size(108, 19);
        chkShowNewPassword.TabIndex = 5;
        chkShowNewPassword.Text = "Show Password";
        chkShowNewPassword.UseVisualStyleBackColor = true;
        chkShowNewPassword.CheckedChanged += chkShowNewPassword_CheckedChanged;
        // 
        // txtConfirmPassword
        // 
        txtConfirmPassword.Image = WinForm.Properties.Resources.LoginScreen;
        txtConfirmPassword.isPassword = true;
        txtConfirmPassword.Location = new Point(25, 90);
        txtConfirmPassword.Name = "txtConfirmPassword";
        txtConfirmPassword.Size = new Size(250, 30);
        txtConfirmPassword.TabIndex = 9;
        txtConfirmPassword.Text = "Confirn Password";
        // 
        // txtNewPassword
        // 
        txtNewPassword.Image = WinForm.Properties.Resources.LoginScreen;
        txtNewPassword.isPassword = true;
        txtNewPassword.Location = new Point(25, 40);
        txtNewPassword.Name = "txtNewPassword";
        txtNewPassword.Size = new Size(250, 30);
        txtNewPassword.TabIndex = 8;
        txtNewPassword.Text = "New Password";
        // 
        // btnSavePassword
        // 
        btnSavePassword.Location = new Point(35, 165);
        btnSavePassword.Name = "btnSavePassword";
        btnSavePassword.Size = new Size(230, 35);
        btnSavePassword.TabIndex = 11;
        btnSavePassword.Text = "Save";
        btnSavePassword.UseVisualStyleBackColor = true;
        btnSavePassword.Click += saveNewPasswordButton_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = WinForm.Properties.Resources.WhatsApp_Image_2024_06_21_at_21_04_43a;
        pictureBox1.Location = new Point(0, 46);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(300, 156);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 14;
        pictureBox1.TabStop = false;
        // 
        // LoginForm
        // 
        AcceptButton = btnLogin;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        ClientSize = new Size(300, 500);
        Controls.Add(pictureBox1);
        Controls.Add(btnBack);
        Controls.Add(btnExit);
        Controls.Add(pnlLogin);
        Controls.Add(pnlNewPassword);
        Controls.Add(pnlResetPassword);
        FormBorderStyle = FormBorderStyle.None;
        Name = "LoginForm";
        Text = "Form1";
        pnlLogin.ResumeLayout(false);
        pnlLogin.PerformLayout();
        pnlResetPassword.ResumeLayout(false);
        pnlNewPassword.ResumeLayout(false);
        pnlNewPassword.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel pnlLogin;
    private Button btnExit;
    private Button btnBack;
    private Panel pnlNewPassword;
    private Panel pnlResetPassword;
    private Button btnLogin;
    private Button btnSavePassword;
    private Button btnReset;
    private Label label1;
    private LinkLabel btnResetPassword;
    private Label label2;
    private Controls.TextBoxGroup txtPassword;
    private Controls.TextBoxGroup txtUsername;
    private Controls.TextBoxGroup txtUsernameforReset;
    private Controls.TextBoxGroup txtRecoveryPhrase;
    private Controls.TextBoxGroup txtConfirmPassword;
    private Controls.TextBoxGroup txtNewPassword;
    private CheckBox chkShowPassword;
    private CheckBox chkShowNewPassword;
    private Label lblLoginError;
    private Label lblResetError;
    private Label lblChangeError;
    private PictureBox pictureBox1;
}
