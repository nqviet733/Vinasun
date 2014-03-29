using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class EntityModelImpl: EntityModel
    {
        //Create new entity
        void EntityModel.addEntity(EntityDiagramContainer container, Entity entity)
        {
            try
            {
                container.Entities.Add(entity);
                container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new entity. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

        //retrieve a entity already exist
        Entity EntityModel.retrieveEntity(EntityDiagramContainer container, int entityId)
        {
            try
            {
                return container.Entities.Find(entityId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a entity. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //retrieve all entities
        IList<Entity> EntityModel.retrieveAllEntities(EntityDiagramContainer container)
        {
            try
            {
                return container.Set<Entity>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list entity. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //update a entity already exist
        void EntityModel.updateEntity(EntityDiagramContainer container, Entity entityIn)
        {
            try
            {
                var entity = container.Entities.FirstOrDefault(c => c.id == entityIn.id);
                entity.firstname = entityIn.firstname;
                entity.lastname = entityIn.lastname;
                entity.birthday = entityIn.birthday;
                entity.gender = entityIn.gender;
                entity.email = entityIn.email;
                entity.businessPhone = entityIn.businessPhone;
                entity.dateJoin = entityIn.dateJoin;
                entity.UserRole = entityIn.UserRole;
                entity.Leader = entityIn.Leader;
                entity.Group = entity.Group;

                container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist entity. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

        //delete a entity already exist
        void EntityModel.deleteEntity(EntityDiagramContainer container, Entity entityIn)
        {
            try
            {
                var e = (from entity in container.Entities
                         where entity.id == entityIn.id
                         select entity).FirstOrDefault();
                container.Entities.Remove(e);
                container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist entity. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }
    }
}
