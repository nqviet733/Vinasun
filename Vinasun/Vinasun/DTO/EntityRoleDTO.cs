using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface EntityRoleDTO
    {

        int addEntityRole(EntityDiagramContainer container, EntityRole entityRole);
        EntityRole retrieveEntityRole(EntityDiagramContainer container, int entityRoleId);
        IList<EntityRole> retrieveAllEntityRoles(EntityDiagramContainer container);
        int updateEntityRole(EntityDiagramContainer container, EntityRole entityRole);
        int deleteEntityRole(EntityDiagramContainer container, EntityRole entityRole);

    }
}
