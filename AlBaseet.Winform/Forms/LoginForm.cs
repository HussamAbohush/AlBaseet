namespace AlBaseet.Winform;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
        CenterToScreen();
    }


    #region FormControls

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
        }
        else if (pnlNewPassword.Visible)
        {
            pnlNewPassword.Visible = false;
            pnlResetPassword.Visible = true;
        }
        else
        {
            pnlLogin.Visible = false;
            pnlResetPassword.Visible = true;

        }
    }
    #endregion

    #region LoginPanel
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

    }
    private void btnResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        pnlLogin.Visible = false;
        pnlResetPassword.Visible = true;
        btnBack.Visible = true;
    }

    #endregion

    #region resetPasswordPanel
    private void resetButton_Click(object sender, EventArgs e)
    {
        pnlResetPassword.Visible = false;
        pnlNewPassword.Visible = true;

    }
    #endregion

    #region newPasswordPanel
    private void saveNewPasswordButton_Click(object sender, EventArgs e)
    {

    }

    #endregion




}
