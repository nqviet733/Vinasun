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
        void GroupModel.addGroup(EntityDiagramContainer container, Group group)
        {
            try
            {
                container.Groups.Add(group);
                container.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unable to add new group. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

        //retrieve a group already exist
        Group GroupModel.retrieveGroup(EntityDiagramContainer container, int groupId)
        {
            try
            {
                return container.Groups.Find(groupId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a group. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //retrieve all groups
        IList<Group> GroupModel.retrieveAllGroups(EntityDiagramContainer container)
        {
            try
            {
                return container.Set<Group>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list group. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //update a group already exist
        void GroupModel.updateGroup(EntityDiagramContainer container, Group group)
        {
            try
            {
                var g = container.Groups.FirstOrDefault(c => c.id == group.id);
                g.name = group.name;
                g.address = group.address;
                container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist group. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

        //delete a group already exist
        void GroupModel.deleteGroup(EntityDiagramContainer container, Group groupIn)
        {
            try
            {
                var gr = (from g in container.Groups
                          where g.id == groupIn.id
                          select g).FirstOrDefault();
                container.Groups.Remove(gr);
                container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist group. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

    }
}
