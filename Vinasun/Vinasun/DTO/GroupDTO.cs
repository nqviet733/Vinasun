using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface GroupDTO
    {

        int addGroup(EntityDiagramContainer container, Group group);
        Group retrieveGroup(EntityDiagramContainer container, int groupId);
        IList<Group> retrieveAllGroups(EntityDiagramContainer container);
        int updateGroup(EntityDiagramContainer container, Group group);
        int deleteGroup(EntityDiagramContainer container, Group group);

    }
}
