using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class CollectionModelImpl : CollectionModel
    {

        //Create new collection
        int CollectionModel.addCollection(EntityDiagramContainer container, Collection collection)
        {
            int signal = 0;
            try
            {
                container.Collections.Add(collection);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new collection. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a collection already exist
        Collection CollectionModel.retrieveCollection(EntityDiagramContainer container, int collectionId)
        {
            Collection c = null;
            try
            {
                c = container.Collections.Find(collectionId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a collection. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return c;
        }

        //retrieve all collections
        IList<Collection> CollectionModel.retrieveAllCollections(EntityDiagramContainer container)
        {
            IList<Collection> cs = null;
            try
            {
                cs = container.Set<Collection>().ToList();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list collection. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (cs == null)
                {
                    cs = new List<Collection>();
                }
            }
            return cs;
        }

        //update a collection already exist
        int CollectionModel.updateCollection(EntityDiagramContainer container, Collection collectionIn)
        {
            int signal = 0;
            try
            {
                var collection = container.Collections.FirstOrDefault(c => c.id == collectionIn.id);
                
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist collection. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a collection already exist
        int CollectionModel.deleteCollection(EntityDiagramContainer container, Collection collectionIn)
        {
            int signal = 0;
            try
            {
                var c = (from collection in container.Collections
                         where collection.id == collectionIn.id
                         select collection).FirstOrDefault();
                container.Collections.Remove(c);
                signal = container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist collection. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

    }
}
