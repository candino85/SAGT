using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application.UI
{
    public partial class frmRoles : Form
    {

        private IList<FormList> GetFormList()
        {
            IList<FormList> lista = new List<FormList>();
            Module[] modulos = Assembly.GetExecutingAssembly().GetModules();
            foreach (Module m in modulos)
            {
                string nameSpace = m.Assembly.GetName().Name;
                Type[] tipos = m.GetTypes();
                foreach (Type t in tipos)
                {
                    if (t.IsSubclassOf(typeof(Form)))
                        lista.Add(new FormList() { Name = t.Name, FullName = t.FullName });
                }
            }

            return lista;
        }

        public class FormList
        {
            public string Name { get; set; }
            public string FullName { get; set; }
        }

        public frmRoles()
        {
            InitializeComponent();
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            List<FormList> formLists = GetFormList().ToList();
            foreach (FormList form in formLists)
            {
                tvPermisosDisponibles.Nodes.Add(form.FullName);
            }
        }
    }
}
