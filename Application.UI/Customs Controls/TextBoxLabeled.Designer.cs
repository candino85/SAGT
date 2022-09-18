
namespace Application.UI.Customs_Controls
{
    partial class TextBoxLabeled
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
            this.lblTextBox = new System.Windows.Forms.Label();
            this.txtTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTextBox
            // 
            this.lblTextBox.AutoSize = true;
            this.lblTextBox.Location = new System.Drawing.Point(-1, 4);
            this.lblTextBox.Name = "lblTextBox";
            this.lblTextBox.Size = new System.Drawing.Size(33, 13);
            this.lblTextBox.TabIndex = 0;
            this.lblTextBox.Text = "Label";
            // 
            // txtTextBox
            // 
            this.txtTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTextBox.Location = new System.Drawing.Point(0, 20);
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.Size = new System.Drawing.Size(157, 20);
            this.txtTextBox.TabIndex = 1;
            // 
            // TextBoxLabeled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTextBox);
            this.Controls.Add(this.lblTextBox);
            this.Name = "TextBoxLabeled";
            this.Size = new System.Drawing.Size(157, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextBox;
        private System.Windows.Forms.TextBox txtTextBox;
    }
}
