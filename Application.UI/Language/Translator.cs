using Application.BE;
using Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Application.UI.Language
{
    public class Translator
    {
        public static void Translate(Form form)
        {
            var language = SessionManager.GetInstance.language;

            if (language != null && form.Tag != null)
            {
                form.Text = GetTranslation(language, form.Tag.ToString()) ?? form.Text;
                UpdateLanguageRecursiveControls(language, form.Controls);
            }
        }

        public static void UpdateLanguageRecursiveControls(BE.Language language, Control.ControlCollection parentControlCollection)
        {
            foreach (Control control in parentControlCollection)
            {
                if (control.Controls.Count > 0)
                {
                    UpdateLanguageRecursiveControls(language, control.Controls);
                }

                if (control.Tag != null)
                {
                    //CAMBIAR IDIOMA CUSTOM CONTROLS TEXTBOXLABELED
                
                    control.Text = GetTranslation(language, control.Tag.ToString()) ?? control.Text;
                }

                if (control is MenuStrip menuStrip && menuStrip.Items.Count > 0)
                {
                    UpdateToolStrip(language, menuStrip.Items);
                }

                if (control is DataGridView dataGridView)
                {
                    UpdateDataGridViewColumns(dataGridView, language);
                }
            }
        }

        private static void UpdateToolStrip(BE.Language language, ToolStripItemCollection parent)
        {
            foreach (ToolStripMenuItem control in parent)
            {
                control.Text = GetTranslation(language, control.Tag.ToString()) ?? control.Text;

                if (control.DropDownItems.Count > 0)
                {
                    UpdateToolStrip(language, control.DropDownItems);
                }
            }
        }

        private static void UpdateDataGridViewColumns(DataGridView dataGridView, BE.Language language)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.HeaderText = GetTranslation(language, column.HeaderText) ?? column.HeaderText;

                if (column is DataGridViewButtonColumn buttonColumn)
                {
                    buttonColumn.Text = GetTranslation(language, column.Tag.ToString()) ?? buttonColumn.Text;
                }
            }

            dataGridView.Refresh();
        }

        private static string GetTranslation(BE.Language language, string key)
        {
            return language.Translations.Find(t => t.Key.Equals(key, StringComparison.OrdinalIgnoreCase))?.Translate;
        }
    }

}
