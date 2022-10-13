using Application.DLL;
using Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BLL
{
    public class Permission
    {
        readonly PermissionRepository _repository;

        public Permission()
        {
            _repository = new PermissionRepository();
        }

        public IList<Component> GetAll(string roleId)
        {
            return _repository.GetAll(roleId);
        }

        public Array GetAllPermissions()
        {
            return _repository.GetAllPermissions();
        }

        public IList<Services.Role> GetAllRolesFromDB()
        {
            return _repository.GetAllRolesFromDB();
        }

        public IList<Services.Permission> GetAllPermissionsFromDB()
        {
            return _repository.GetAllPermissionsFromDB(); 
        }

        public Component SaveComponent(Component component)
        {
            return _repository.SaveComponent(component);
        }

        public int DeleteComponent(Component component)
        {
            return _repository.DeleteComponent(component);
        }

        public Component GetComponent(Component component)
        {
            return _repository.GetComponent(component);
        }

        public bool AlreadyExistComponent(Component component, int idComp)
        {
            bool exist = false;

            if (component.Id.Equals(idComp))
                exist = true;
            else
            {
                foreach (var c in component.GetChild)
                {
                    exist = AlreadyExistComponent(c, idComp);
                    if (exist) return true;
                }
            }
            return exist;
        }

        public Role GetRoleComponents(Role role)
        {
            foreach(var c in GetAll($"= {role.Id}"))
            {
                role.AddChild(c);
            }
            return role;
        }

        public void SaveRole(Role role)
        {
            _repository.SaveRole(role);
        }

        public bool FindUserPermissions(PermissionType permissionType,UserPermission userPermission)
        {
            return _repository.FindUserPermissions(permissionType, userPermission);
        }

        public int GetUserRole(int idUser)
        {
            return _repository.GetUserRole(idUser);
        }

        public int SaveUserPermission(int idUser, int idPermission)
        {
            return _repository.SaveUserPermission(idUser,idPermission);
        }
    }
}
