using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;
using Vinasun.View;
using Vinasun.DTO;
using DevComponents.DotNetBar.Controls;

namespace Vinasun.Model
{
    class UserRoleModel
    {
        public void showDGV(DataGridViewX dgv, EntityDiagramContainer entitiesContainer)
        {
            UserRoleDTO userRoleDTO = new UserRoleDTOImpl();
            IList<UserRole> userRoles = userRoleDTO.retrieveAllUserRoles(entitiesContainer);
            dgv.DataSource = null;
            dgv.DataSource = userRoles;
            dgv.Columns["id"].HeaderText = "ID";
            dgv.Columns["id"].Visible = false;
        }

        public Dictionary<int, string> getUserRoles(EntityDiagramContainer entitiesContainer)
        {
            Dictionary<int, string> userRoles = new Dictionary<int, string>();
            UserRoleDTO userRoleDTO = new UserRoleDTOImpl();
            foreach (UserRole userRole in userRoleDTO.retrieveAllUserRoles(entitiesContainer))
            {
                userRoles.Add(userRole.id, userRole.permission);
            }
            return userRoles;
        }
    }
}
