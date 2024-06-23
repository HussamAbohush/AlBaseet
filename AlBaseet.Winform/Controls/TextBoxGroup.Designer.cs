
namespace AlBaseet.Winform.Controls
{
    partial class TextBoxGroup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picGroup = new PictureBox();
            linUsername = new Panel();
            txtTextBoxGroup = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picGroup).BeginInit();
            SuspendLayout();
            // 
            // picGroup
            // 
            picGroup.Image = WinForm.Properties.Resources.LoginUser;
            picGroup.Location = new Point(10, 7);
            picGroup.Name = "picGroup";
            picGroup.Size = new Size(25, 16);
            picGroup.SizeMode = PictureBoxSizeMode.CenterImage;
            picGroup.TabIndex = 11;
            picGroup.TabStop = false;
            // 
            // linUsername
            // 
            linUsername.Anchor = AnchorStyles.None;
            linUsername.BackColor = SystemColors.Highlight;
            linUsername.Location = new Point(5, 28);
            linUsername.Name = "linUsername";
            linUsername.Size = new Size(240, 1);
            linUsername.TabIndex = 10;
            // 
            // txtTextBoxGroup
            // 
            txtTextBoxGroup.Anchor = AnchorStyles.None;
            txtTextBoxGroup.BorderStyle = BorderStyle.None;
            txtTextBoxGroup.ForeColor = Color.DarkGray;
            txtTextBoxGroup.Location = new Point(42, 7);
            txtTextBoxGroup.Name = "txtTextBoxGroup";
            txtTextBoxGroup.Size = new Size(200, 16);
            txtTextBoxGroup.TabIndex = 9;
            txtTextBoxGroup.Text = "Hint";
            txtTextBoxGroup.Enter += txtname_Enter;
            txtTextBoxGroup.Leave += txtname_Leave;
            // 
            // TextBoxGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(picGroup);
            Controls.Add(linUsername);
            Controls.Add(txtTextBoxGroup);
            Name = "TextBoxGroup";
            Size = new Size(250, 30);
            ((System.ComponentModel.ISupportInitialize)picGroup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picGroup;
        private Panel linUsername;
        private TextBox txtTextBoxGroup;
    }
}
