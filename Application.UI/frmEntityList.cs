using Application.ABSTRACTIONS;
using Application.Services;
using Application.UI.Language;
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
    public partial class frmEntityList : Form, ILanguageObserver
    {
        BE.Entity Entity_BE;
        BLL.Entity entity_BLL;
        public frmEntityList()
        {
            InitializeComponent();
            entity_BLL = new BLL.Entity();
            Bind();
        }

        private void btnCreateEntity_Click(object sender, EventArgs e)
        {
            frmEntity frmEntity = new frmEntity(this);
            frmMain frmMain = (frmMain)this.MdiParent;
            frmEntity.Show();
        }

        private void dgvEntities_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEntity frmEntity = new frmEntity((BE.Entity)dgvEntities.Rows[e.RowIndex].DataBoundItem, this);
            frmMain frmMain = (frmMain)this.MdiParent;
            frmEntity.Show();
        }

        public void Bind()
        {
            dgvEntities.DataSource = null;
            dgvEntities.DataSource = entity_BLL.EntityList();
            dgvEntities.Columns["Id"].Visible = false;
        }

        public void updateLanguage(ILanguage language)
        {
            Translator.Translate(this);
        }

        private void frmEntityList_Load(object sender, EventArgs e)
        {
            updateLanguage(SessionManager.GetInstance.language);
        }

        private void frmEntityList_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionManager.GetInstance.UnsubscribeObserver(this);
        }
    }
}
