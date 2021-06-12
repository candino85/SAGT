using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application.UI
{
    public partial class LabeledTextBox : UserControl
    {
        public LabeledTextBox()
        {
            InitializeComponent();
        }

        public string TextLabel { get { return label.Text; } set { label.Text = value; } }

        public string TextBox { get { return textbox.Text; } set { textbox.Text = value; } }

        public void IsPassword(char c)
        {
            textbox.PasswordChar = c;
        }

        protected void CambiarColor(Color unColor)
        {
            textbox.ForeColor = unColor;
        }

        public virtual void ValidarControl()
        {
            if (string.IsNullOrWhiteSpace(this.textbox.Text))
                CambiarColor(Color.Red);
        }
    }
}
