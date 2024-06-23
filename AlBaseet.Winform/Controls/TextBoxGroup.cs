using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlBaseet.Winform.Controls
{
    public partial class TextBoxGroup : UserControl
    {
        private Image image;
        private string text;
        public TextBoxGroup()
        {
            InitializeComponent();
        }


        public Image Image
        {
            get => image;
            set
            {
                image = value;
                picGroup.Image = image;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get => txtTextBoxGroup.Text;
            set
            {
                text = value;
                txtTextBoxGroup.Text = value;
            }
        }



        [Description("Hide the writen chars"), Category("Data")]
        public bool isPassword
        {
            get;
            set;
        }
        public void showPassword(bool show)
        {
            if (show)
            {
                isPassword = false;
                txtTextBoxGroup.UseSystemPasswordChar = false;
            }
            else
            {
                isPassword = true;
                txtTextBoxGroup.UseSystemPasswordChar = true;
            }
        }

        private void txtname_Enter(object sender, EventArgs e)
        {
            if (txtTextBoxGroup.Text == text)
            {
                txtTextBoxGroup.Text = "";
                txtTextBoxGroup.ForeColor = Color.Black;
                if (isPassword) txtTextBoxGroup.UseSystemPasswordChar = true;
            }

        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtTextBoxGroup.Text == "")
            {
                txtTextBoxGroup.Text = text;
                txtTextBoxGroup.ForeColor = Color.DarkGray;
                if (isPassword) txtTextBoxGroup.UseSystemPasswordChar = false;
            }

        }
    }
}
