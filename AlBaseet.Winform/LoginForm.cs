namespace AlBaseet.Winform;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }


    #region FormControls
    // first load
    private void LoginForm_Load(object sender, EventArgs e)
    {
        pnlLogin.Visible = true;
        resetPasswordPanel.Visible = false;
        newPasswordPanel.Visible = false;
    }
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
        if (resetPasswordPanel.Visible)
        {
            pnlLogin.Visible = true;
            resetPasswordPanel.Visible = false;
            backButton.Visible = false;
        }
        else if (newPasswordPanel.Visible)
        {
            newPasswordPanel.Visible = false;
            resetPasswordPanel.Visible = true;
        }
        else
        {
            pnlLogin.Visible = false;
            resetPasswordPanel.Visible = true;

        }
    }
    #endregion

    #region LoginPanel
    private void loginButton_Click(object sender, EventArgs e)
    {

    }
    private void btnResetPassword_Click(object sender, EventArgs e)
    {

    }
    private void btnResetPassword2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        pnlLogin.Visible = false;
        resetPasswordPanel.Visible = true;
        backButton.Visible = true;
    }
    #endregion

    #region resetPasswordPanel
    private void resetButton_Click(object sender, EventArgs e)
    {
        resetPasswordPanel.Visible = false;
        newPasswordPanel.Visible = true;
    }
    #endregion

    #region newPasswordPanel
    private void saveNewPasswordButton_Click(object sender, EventArgs e)
    {

    }

    #endregion


}
