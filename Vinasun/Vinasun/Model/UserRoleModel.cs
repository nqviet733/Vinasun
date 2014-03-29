using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface UserRoleModel
    {

        void addUserRole(EntityDiagramContainer container, UserRole userRole);
        UserRole retrieveUserRole(EntityDiagramContainer container, int userRoleId);
        IList<UserRole> retrieveAllUserRoles(EntityDiagramContainer container);
        void updateUserRole(EntityDiagramContainer container, UserRole userRole);
        void deleteUserRole(EntityDiagramContainer container, UserRole userRole);

    }
}
