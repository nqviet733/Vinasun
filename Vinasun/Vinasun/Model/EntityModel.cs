using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface EntityModel
    {
        void addEntity(EntityDiagramContainer container, Entity entity);
        Entity retrieveEntity(EntityDiagramContainer container, int entityId);
        IList<Entity> retrieveAllEntities(EntityDiagramContainer container);
        void updateEntity(EntityDiagramContainer container, Entity entity);
        void deleteEntity(EntityDiagramContainer container, Entity entity);
    }
}
