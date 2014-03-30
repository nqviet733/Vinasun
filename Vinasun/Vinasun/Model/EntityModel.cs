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

        int addEntity(EntityDiagramContainer container, Entity entity);
        Entity retrieveEntity(EntityDiagramContainer container, int entityId);
        IList<Entity> retrieveAllEntities(EntityDiagramContainer container);
        int updateEntity(EntityDiagramContainer container, Entity entity);
        int deleteEntity(EntityDiagramContainer container, Entity entity);

    }
}
