using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class CollectionModelImpl
    {

        //Create new collection
        void CollectionModel.addCollection(EntityDiagramContainer container, Collection collection)
        {
            try
            {
                container.Collections.Add(collection);
                container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new collection. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

        //retrieve a collection already exist
        Collection CollectionModel.retrieveCollection(EntityDiagramContainer container, int collectionId)
        {
            try
            {
                return container.Collections.Find(collectionId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a collection. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //retrieve all collections
        IList<Collection> CollectionModel.retrieveAllCollections(EntityDiagramContainer container)
        {
            try
            {
                return container.Set<Collection>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list collection. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //update a collection already exist
        void CollectionModel.updateCollection(EntityDiagramContainer container, Collection collectionIn)
        {
            try
            {
                var collection = container.Collections.FirstOrDefault(c => c.id == collectionIn.id);
                
                container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist collection. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

        //delete a collection already exist
        void CollectionModel.deleteCollection(EntityDiagramContainer container, Collection collectionIn)
        {
            try
            {
                var c = (from collection in container.Collections
                         where collection.id == collectionIn.id
                         select collection).FirstOrDefault();
                container.Collections.Remove(c);
                container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist collection. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

    }
}
