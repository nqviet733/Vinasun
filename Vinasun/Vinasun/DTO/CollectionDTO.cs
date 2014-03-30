using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface CollectionDTO
    {

        int addCollection(EntityDiagramContainer container, Collection collection);
        Collection retrieveCollection(EntityDiagramContainer container, int collectionId);
        IList<Collection> retrieveAllCollections(EntityDiagramContainer container);
        int updateCollection(EntityDiagramContainer container, Collection collection);
        int deleteCollection(EntityDiagramContainer container, Collection collection);

    }
}
