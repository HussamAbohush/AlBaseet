using AlBaseet.Core.Entities;
using AlBaseet.Core.Services;
using AlBaseet.WinForm.Forms;


namespace AlBaseet.Winform.Forms;

public partial class LoginForm : Form
{
    private readonly ILoginService _loginService;
    public LoginForm(ILoginService loginService)
    {
        _loginService = loginService;
        _loginService.Authenticate("", "");
        InitializeComponent();
        CenterToScreen();

    }


    #region Form Controls
    // Moveable without Border
    protected override void WndProc(ref Message m)
    {
        switch (m.Msg)
        {
            case 0x84:
                base.WndProc(ref m);
                if ((int)m.Result == 0x1)
                    m.Result = (IntPtr)0x2;
                return;
        }

        base.WndProc(ref m);
    }
    // Exit button
    private void ExitButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
    // Back button
    private void backButton_Click(object sender, EventArgs e)
    {
        if (pnlResetPassword.Visible)
        {
            pnlLogin.Visible = true;
            pnlResetPassword.Visible = false;
            btnBack.Visible = false;
            lblResetError.Text = string.Empty;
        }
        else if (pnlNewPassword.Visible)
        {
            pnlNewPassword.Visible = false;
            pnlResetPassword.Visible = true;
            lblChangeError.Text = string.Empty;
        }
        else
        {
            pnlLogin.Visible = false;
            pnlResetPassword.Visible = true;

        }
    }
    #endregion

    #region Login Panel
    private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
    {
        if (chkShowPassword.Checked)
        {
            txtPassword.showPassword(true);
        }
        else
        {
            txtPassword.showPassword(false);
        }
    }
    private void loginButton_Click(object sender, EventArgs e)
    {
        var tryLogin = _loginService.Authenticate(txtUsername.Text, txtPassword.Text);
        if (tryLogin.isAuthenticated)
        {
            Form NextForm = tryLogin.role == Role.Admin ? new AdminForm() : new EmployeeForm();
            NextForm.Show();
            Hide();
        }
        else
        {
            lblLoginError.ForeColor = Color.Tomato;
            lblLoginError.Text = "Incorrect Username or password";
            label1.Visible = true;
            label2.Visible = true;

        }
    }
    private void btnResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        pnlLogin.Visible = false;
        pnlResetPassword.Visible = true;
        btnBack.Visible = true;
        lblLoginError.Text = string.Empty;
    }
    #endregion

    #region Reset Password Panel
    private void resetButton_Click(object sender, EventArgs e)
    {
        var passwordReset = _loginService.ResetPassword(txtUsernameforReset.Text, txtRecoveryPhrase.Text);
        if (passwordReset)
        {
            pnlResetPassword.Visible = false;
            pnlNewPassword.Visible = true;
            lblResetError.Text = string.Empty;
        }
        else
        {
            lblResetError.ForeColor = Color.Tomato;
            lblResetError.Text = "Incorrect Username or Recovery Phrase";
        }


    }
    #endregion

    #region New Password Panel
    private void saveNewPasswordButton_Click(object sender, EventArgs e)
    {
        if (txtNewPassword.Text == txtConfirmPassword.Text)
        {
            var passwordChanged = _loginService.ChangePassword(txtUsernameforReset.Text, txtNewPassword.Text);
            if (passwordChanged)
            {
                pnlNewPassword.Visible = false;
                pnlLogin.Visible = true;
                lblLoginError.Text = "Password Changed Sccessfully ";
                lblLoginError.ForeColor = Color.Green;
                lblChangeError.Text = string.Empty;
            }
            else
            {
                lblChangeError.Text = "Password should be more than 8 chars and at least (1 upper case and 1 number )";
            }
        }
        else
        {
            lblChangeError.Text = " Passwords do not match ";
        }

    }
    private void chkShowNewPassword_CheckedChanged(object sender, EventArgs e)
    {
        if (chkShowNewPassword.Checked)
        {
            txtNewPassword.showPassword(true);
            txtConfirmPassword.showPassword(true);
        }
        else
        {
            txtNewPassword.showPassword(false);
            txtConfirmPassword.showPassword(false);

        }
    }
    #endregion



}
