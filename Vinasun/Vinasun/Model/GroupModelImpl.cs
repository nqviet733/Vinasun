using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class GroupModelImpl: GroupModel
    {

        //Create new group
        int GroupModel.addGroup(EntityDiagramContainer container, Group group)
        {
            int signal = 0;
            try
            {
                container.Groups.Add(group);
                signal = container.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unable to add new group. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a group already exist
        Group GroupModel.retrieveGroup(EntityDiagramContainer container, int groupId)
        {
            Group g = null;
            try
            {
                g = container.Groups.Find(groupId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a group. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return g;
        }

        //retrieve all groups
        IList<Group> GroupModel.retrieveAllGroups(EntityDiagramContainer container)
        {
            IList<Group> gs = null;
            try
            {
                gs = container.Set<Group>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list group. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (gs == null)
                {
                    gs = new List<Group>();
                }
            }
            return gs;
        }

        //update a group already exist
        int GroupModel.updateGroup(EntityDiagramContainer container, Group group)
        {
            int signal = 0;
            try
            {
                container.Groups.FirstOrDefault(c => c.id == group.id);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist group. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a group already exist
        int GroupModel.deleteGroup(EntityDiagramContainer container, Group groupIn)
        {
            int signal = 0;
            try
            {
                var g = (from gr in container.Groups
                          where gr.id == groupIn.id
                          select gr).FirstOrDefault();
                container.Groups.Remove(g);
                signal = container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist group. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

    }
}
