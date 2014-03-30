using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface UserRoleDTO
    {

        int addUserRole(EntityDiagramContainer container, UserRole userRole);
        UserRole retrieveUserRole(EntityDiagramContainer container, int userRoleId);
        IList<UserRole> retrieveAllUserRoles(EntityDiagramContainer container);
        int updateUserRole(EntityDiagramContainer container, UserRole userRole);
        int deleteUserRole(EntityDiagramContainer container, UserRole userRole);

    }
}
