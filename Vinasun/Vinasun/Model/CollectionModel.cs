using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface CollectionModel
    {

        void addCollection(EntityDiagramContainer container, Collection collection);
        Collection retrieveCollection(EntityDiagramContainer container, int collectionId);
        IList<Collection> retrieveAllCollections(EntityDiagramContainer container);
        void updateCollection(EntityDiagramContainer container, Collection collection);
        void deleteCollection(EntityDiagramContainer container, Collection collection);
    }
}
