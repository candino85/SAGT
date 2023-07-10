using Application.ABSTRACTIONS;
using Application.BLL;
using Application.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Application.UI.Language
{
    public partial class frmLanguage : Form, ILanguageObserver
    {
        readonly LanguageService languageService;
        public frmLanguage()
        {
            InitializeComponent();
            languageService = new LanguageService();
        }

        private void frmLanguage_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
            DataGridViewConfig();
            
            SessionManager.GetInstance.SubscribeObserver(this);
            updateLanguage(SessionManager.GetInstance.language);
        }

        private void frmLanguage_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }

        private void DataGridViewConfig() 
        {
            dgvTranslations.AllowUserToAddRows = false;
            dgvTranslations.AllowUserToDeleteRows = false;
            dgvTranslations.AllowUserToResizeRows = false;
            dgvTranslations.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvTranslations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTranslations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTranslations.ReadOnly = true;
            dgvTranslations.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvTranslations.RowHeadersVisible = false;
            dgvTranslations.MultiSelect = false;
        }

        private void dgvTranslations_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTranslations?.CurrentCell?.ColumnIndex == 0 || dgvTranslations?.CurrentCell == null)
            {
                btnCreateTranslation.Visible = false;
                btnUpdateTranslate.Visible = false;
                txtTranslationText.Visible = false;
                return;
            }
            txtTranslationText.Visible = true;
            txtTranslationText.Text = dgvTranslations.CurrentCell.Value.ToString();
            txtTranslationText.Focus();
            txtTranslationText.SelectAll();

            if (dgvTranslations.CurrentCell.Value.ToString().IsNullOrEmpty())
            {
                btnCreateTranslation.Visible = true;
                btnUpdateTranslate.Visible = false;
            }
            else
            {
                btnCreateTranslation.Visible = false;
                btnUpdateTranslate.Visible = true;
            }
        }

        private void btnCreateTranslation_Click(object sender, EventArgs e)
        {
            if (dgvTranslations.CurrentCell.ColumnIndex == 0) return;

            if(txtTranslationText.Text.RemoveWhitespaces().IsNullOrEmpty())
            {
                MessageBox.Show("Ingrese una traducción válida");
                return;
            }

            DataGridViewCell cellSelected = dgvTranslations.CurrentCell;

            languageService.CreateTranslation(
                dgvTranslations.Rows[dgvTranslations.CurrentCell.RowIndex].Cells[0].Value.ToString(),
                txtTranslationText.Text,
                dgvTranslations.Columns[dgvTranslations.CurrentCell.ColumnIndex].HeaderText
                                             );

            RefreshDataGrid();
        }

        public void RefreshDataGrid()
        {
            dgvTranslations.DataSource = languageService.GetDataSet();
            dgvTranslations.DataMember = "myTable";
        }

        private void btnUpdateTranslate_Click(object sender, EventArgs e)
        {
            if (dgvTranslations.CurrentCell.ColumnIndex == 0) return;

            if (txtTranslationText.Text.RemoveWhitespaces().IsNullOrEmpty())
            {
                MessageBox.Show("Ingrese una traducción válida");
                return;
            }

            DataGridViewCell cellSelected = dgvTranslations.CurrentCell;

            languageService.UpdateTranslation(
                dgvTranslations.Rows[dgvTranslations.CurrentCell.RowIndex].Cells[0].Value.ToString(),
                txtTranslationText.Text,
                dgvTranslations.Columns[dgvTranslations.CurrentCell.ColumnIndex].HeaderText
                                             );

            RefreshDataGrid();
        }

        private void btnCreateNewLanguage_Click(object sender, EventArgs e)
        {
            frmLanguageNew frm = new frmLanguageNew();
            frm.ShowDialog();
            RefreshDataGrid();
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }


    }
}
