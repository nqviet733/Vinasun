using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class EntityDTOImpl: EntityDTO
    {

        //Create new entity
        int EntityDTO.addEntity(EntityDiagramContainer container, Entity entity)
        {
            int signal = 0;
            try
            {
                container.Entities.Add(entity);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new entity. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a entity already exist
        Entity EntityDTO.retrieveEntity(EntityDiagramContainer container, int entityId)
        {
            Entity e = null;
            try
            {
                e = container.Entities.Find(entityId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a entity. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return e;
        }

        //retrieve all entities
        IList<Entity> EntityDTO.retrieveAllEntities(EntityDiagramContainer container)
        {
            IList<Entity> es = null;
            try
            {
                es = container.Set<Entity>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list entity. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (es == null)
                {
                    es = new List<Entity>();
                }
            }
            return es;
        }

        //update a entity already exist
        int EntityDTO.updateEntity(EntityDiagramContainer container, Entity entityIn)
        {
            int signal = 0;
            try
            {
                container.Entities.FirstOrDefault(c => c.id == entityIn.id);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist entity. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a entity already exist
        int EntityDTO.deleteEntity(EntityDiagramContainer container, Entity entityIn)
        {
            int signal = 0;
            try
            {
                var e = (from entity in container.Entities
                         where entity.id == entityIn.id
                         select entity).FirstOrDefault();
                container.Entities.Remove(e);
                signal = container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist entity. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

    }
}
