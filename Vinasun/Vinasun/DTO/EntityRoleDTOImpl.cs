using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class EntityRoleDTOImpl : EntityRoleDTO
    {

        //Create new EntityRole
        int EntityRoleDTO.addEntityRole(EntityDiagramContainer container, EntityRole entityRole)
        {
            int signal = 0;
            try
            {
                container.EntityRoles.Add(entityRole);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new EntityRole. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a EntityRole already exist
        EntityRole EntityRoleDTO.retrieveEntityRole(EntityDiagramContainer container, int entityRoleId)
        {
            EntityRole er = null;
            try
            {
                er = container.EntityRoles.Find(entityRoleId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a EntityRole. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return er;
        }

        //retrieve all user roles
        IList<EntityRole> EntityRoleDTO.retrieveAllEntityRoles(EntityDiagramContainer container)
        {
            IList<EntityRole> ers = null;
            try
            {
                ers = container.Set<EntityRole>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list EntityRole. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (ers == null)
                {
                    ers = new List<EntityRole>();
                }
            }
            return ers;
        }

        //update a EntityRole already exist
        int EntityRoleDTO.updateEntityRole(EntityDiagramContainer container, EntityRole entityRoleIn)
        {
            int signal = 0;
            try
            {
                container.EntityRoles.FirstOrDefault(c => c.id == entityRoleIn.id);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist EntityRole. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a EntityRole already exist
        int EntityRoleDTO.deleteEntityRole(EntityDiagramContainer container, EntityRole entityRoleIn)
        {
            int signal = 0;
            try
            {
                var er = (from entityRole in container.EntityRoles
                                where entityRole.id == entityRoleIn.id
                                select entityRole).FirstOrDefault();
                container.EntityRoles.Remove(er);
                signal = container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist EntityRole. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

    }
}
