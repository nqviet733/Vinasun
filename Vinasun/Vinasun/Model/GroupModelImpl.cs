using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinasun.Model
{
    class GroupModelImpl: GroupModel
    {
        void GroupModel.addGroup(EntityDiagramContainer container, group group_in)
        {
            try
            {
                container.groups.Add(group_in);
                container.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: "+ex);
            }
        }
    }
}
