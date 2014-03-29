using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Vinasun.Model
{
    class GroupModelImpl: GroupModel
    {

        //Create new group
        void GroupModel.addGroup(EntityDiagramContainer container, group group)
        {
            try
            {
                container.groups.Add(group);
                container.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unable to add new group. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

        //retrieve a group already exist
        group GroupModel.retrieveGroup(EntityDiagramContainer container, int groupId)
        {
            try
            {
                return container.groups.Find(groupId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a group. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //retrieve all groups
        IList<group> GroupModel.retrieveAllGroup(EntityDiagramContainer container)
        {
            try
            {
                return container.Set<group>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list group. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //update a group already exist
        void GroupModel.updateGroup(EntityDiagramContainer container, group group)
        {
            try
            {
                var g = container.groups.FirstOrDefault(c=>c.id == group.id);
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
        void GroupModel.deleteGroup(EntityDiagramContainer container, group group_in)
        {
            try
            {
                var gr = (from g in container.groups
                          where g.id == group_in.id
                          select g).FirstOrDefault();
                container.groups.Remove(gr);
                container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist group. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }
    }
}
