using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application.UI.Customs_Controls
{
    public partial class TextBoxLabeled : UserControl
    {
        public TextBoxLabeled()
        {
            InitializeComponent();
        }

        public string TextBoxText
        {
            get { return txtTextBox.Text; }
            set { txtTextBox.Text = value; }
        }

        public string LabelText
        {
            get { return lblTextBox.Text; }
            set { lblTextBox.Text = value; }
        }

        public virtual bool ValidateControl()
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(txtTextBox.Text))
            {
                ok = false;
                ChangeColor(Color.Red);
            }

            else
            {
                ChangeColor(Color.Green);
            }

            return ok;
        }

        public void ChangeColor(Color color)
        {
            lblTextBox.ForeColor = color;
        }

    }
}
