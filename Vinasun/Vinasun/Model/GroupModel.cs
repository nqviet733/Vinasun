using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinasun.Model
{
    interface GroupModel
    {
        void addGroup(EntityDiagramContainer container, Group group);
        Group retrieveGroup(EntityDiagramContainer container, int groupId);
        IList<Group> retrieveAllGroups(EntityDiagramContainer container);
        void updateGroup(EntityDiagramContainer container, Group group);
        void deleteGroup(EntityDiagramContainer container, Group group);
    }
}
