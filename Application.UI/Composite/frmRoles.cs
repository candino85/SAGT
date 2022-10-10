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
using Application.Services;

namespace Application.UI
{
    public partial class frmRoles : Form
    {
        BLL.Permission _permission;
        Services.Role selectedRole;
        Services.Component selectedComponent;

        public frmRoles()
        {
            InitializeComponent();
            _permission = new BLL.Permission();

            GetRolesAndCleanCtl();
            GetPermissionsAndCleanCtls();

            cmbPermissionTypes.SelectedItem = null;
        }
        private void frmRoles_Load(object sender, EventArgs e)
        {

        }

        void GetRolesAndCleanCtl()
        {
            cmbRoles.DataSource = null;
            cmbRoles.DataSource = _permission.GetAllRolesFromDB();
            cmbRoles.SelectedItem = null;
            txtRoleName.ClearText();
        }

        void GetPermissionsAndCleanCtls()
        {
            cmbPermisos.DataSource = null;
            cmbPermisos.DataSource = _permission.GetAllPermissions();
            cmbPermisos.SelectedItem = null;
            txtPermissionName.ClearText();
        }

        void LoadPermissions()
        {
            tvAvailablePermission.Nodes.Clear();
            var permissions = _permission.GetAllPermissionsFromDB();
            foreach (Permission p in permissions)
                tvAvailablePermission.Nodes.Add(p.Id.ToString(), p.Name.ToString());
        }

        void LoadRoles()
        {
            tvAvailablePermission.Nodes.Clear();
            var role = _permission.GetAllRolesFromDB();
            foreach (Role r in role)
                tvAvailablePermission.Nodes.Add(r.Id.ToString(), r.Name.ToString());
        }

        private void btnSavePermission_Click(object sender, EventArgs e)
        {
            if (this.cmbPermisos.SelectedItem != null)
            { 
                Permission permission = new Permission()
                {
                    Name = this.txtPermissionName.TextBoxText,
                    Permission = (PermissionType)this.cmbPermisos.SelectedItem
                };

                _permission.SaveComponent(permission);
                tvAvailablePermission.Nodes.Add(permission.Id.ToString(), permission.Name);
                GetPermissionsAndCleanCtls();          
            }
            else
                MessageBox.Show("Debe seleccionar un permiso para poder crearlo");
        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (!string.IsNullOrWhiteSpace(txtRoleName.TextBoxText))
                {
                    Services.Component role = new Role()
                    {
                        Name = txtRoleName.TextBoxText
                    };

                    //comprobar si existe role con el mismo nombre
                    role = _permission.SaveComponent(role);

                    if (role.Id != 0)
                    {
                        GetRolesAndCleanCtl();
                        if(cmbPermissionTypes.SelectedItem != null)
                        { 
                            if ((cmbPermissionTypes.SelectedItem.ToString() == "Roles"))
                            {
                                LoadRoles();
                            }
                        }
                    }                        
                }
                else
                MessageBox.Show("Ingrese un nombre para el nuevo rol");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void btnAddToRole_Click(object sender, EventArgs e)
        {
            Permission permission;
            Role role;

            if (selectedRole != null)
            {
                if (!string.IsNullOrEmpty(tvAvailablePermission.SelectedNode.Name) && !string.IsNullOrEmpty(cmbPermissionTypes.SelectedItem.ToString()))
                {
                    if (cmbPermissionTypes.SelectedItem.ToString() == "Permisos")
                    {
                        permission = new Permission();
                        permission.Name = tvAvailablePermission.SelectedNode.Text;
                        permission.Id = int.Parse(tvAvailablePermission.SelectedNode.Name);

                        if (_permission.AlreadyExistComponent(selectedRole, permission.Id))
                            MessageBox.Show("El permiso que está intentado agregar ya existe");
                        else
                        {
                            selectedRole.AddChild(permission);
                            ShowRoleOnTreeView(false);
                        }
                    }
                    if (cmbPermissionTypes.SelectedItem.ToString() == "Roles")
                    {
                        role = new Role();
                        role.Name = tvAvailablePermission.SelectedNode.Text;
                        role.Id = int.Parse(tvAvailablePermission.SelectedNode.Name);

                        if (_permission.AlreadyExistComponent(selectedRole, role.Id))
                            MessageBox.Show("El rol que está intentado agregar ya existe");
                        else
                        {
                            role = _permission.GetRoleComponents(role);
                            selectedRole.AddChild(role);
                            ShowRoleOnTreeView(false);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Role o Permiso incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol al cual agregar permisos/roles");
            }
        }


        private void cmbRoles_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var tmp = (Role)this.cmbRoles.SelectedItem;

            selectedRole = new Role();
            selectedRole.Id = tmp.Id;
            selectedRole.Name = tmp.Name;

            ShowRoleOnTreeView(true);
        }

        void ShowRoleOnTreeView(bool init)
        {
            if (selectedRole == null) return;

            IList<Services.Component> roleList = null;

            if (init)
            {
                roleList = _permission.GetAll("=" + selectedRole.Id.ToString());

                foreach (var r in roleList)
                    selectedRole.AddChild(r);
            }
            else
                roleList = selectedRole.GetChilds;

            //mostrar en Treeview
            this.tvRole.Nodes.Clear();
            TreeNode root = new TreeNode(selectedRole.Name);
            root.Tag = selectedRole;
            this.tvRole.Nodes.Add(root);

            foreach (var p in roleList)
                ShowInTreeView(root, p);

            this.tvRole.ExpandAll();
        }

        void ShowInTreeView(TreeNode tn, Services.Component component)
        {
            TreeNode n = new TreeNode(component.Name);
            tn.Tag = component;
            tn.Nodes.Add(n);
            if (component.GetChilds != null)
                foreach (var p in component.GetChilds)
                    ShowInTreeView(n, p); //recursividad para armar el arbol de permisos
        }

        private void cmbPermissionTypes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbPermissionTypes.SelectedItem.ToString() == "Permisos")
                LoadPermissions();
            else
                LoadRoles();
        }

        private void btnSaveSelectedRole_Click(object sender, EventArgs e)
        {
            try 
            { 
                _permission.SaveRole(selectedRole);
                MessageBox.Show("El rol se guardó correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al guardar el rol", ex.ToString());
            }

        }

        private void btnRemoveRole_Click(object sender, EventArgs e)
        {
            _permission.DeleteComponent(selectedRole);
        }

        private void btnDeleteComponent_Click(object sender, EventArgs e)
        {
            try
            {            
                var ok = _permission.DeleteComponent(selectedComponent);
                
                if (ok == 1)
                {
                    tvAvailablePermission.Nodes.Clear();
                    
                    if (selectedComponent is Permission)
                    {
                        LoadPermissions();
                        GetPermissionsAndCleanCtls();
                    }
                    else
                    {
                        LoadRoles();
                        GetRolesAndCleanCtl();
                    }
                    ShowRoleOnTreeView(false);
                }
                else
                    MessageBox.Show("El permiso no pudo ser eliminado");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void tvAvailablePermission_AfterSelect(object sender, TreeViewEventArgs e)
        {
                    if (cmbPermissionTypes.SelectedItem.ToString() == "Permisos")
                        selectedComponent = new Permission()
                        {
                            Id = int.Parse(tvAvailablePermission.SelectedNode.Name),
                            Name = tvAvailablePermission.SelectedNode.Text
                        };
                    else
                        selectedComponent = new Role()
                        {
                            Id = int.Parse(tvAvailablePermission.SelectedNode.Name),
                            Name = tvAvailablePermission.SelectedNode.Text
                        };
        }

        private void btnRemovePermission_Click(object sender, EventArgs e)
        {
            //selectedRole.RemoveChild(selectedComponent);
            //tvAvailablePermission.Nodes.Clear();
            //foreach (Services.Component c in selectedRole.GetChilds)
            //    tvAvailablePermission.Nodes.Add(c.Id.ToString(), c.Name.ToString());
        }

        private void tvRole_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //selectedComponent = new Role()
            //{
            //    Id = int.Parse(tvRole.SelectedNode.Name.ToString()),
            //    Name = tvRole.SelectedNode.Text
            //};
        }
    }
}