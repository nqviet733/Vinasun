using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinasun.Model
{
    class TaxiModelImpl:TaxiModel
    {
        
        //Create new Taxi
        void TaxiModel.addTaxi(EntityDiagramContainer container, Taxi taxi)
        {
            try
            {
                container.Taxis.Add(taxi);
                container.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unable to add new Taxi. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

        //retrieve a Taxi already exist
        Taxi TaxiModel.retrieveTaxi(EntityDiagramContainer container, int taxiId)
        {
            try
            {
                return container.Taxis.Find(taxiId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a Taxi. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //retrieve all Taxis
        IList<Taxi> TaxiModel.retrieveAllTaxis(EntityDiagramContainer container)
        {
            try
            {
                return container.Set<Taxi>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list Taxi. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //update a Taxi already exist
        void TaxiModel.updateTaxi(EntityDiagramContainer container, Taxi taxi)
        {
            try
            {
                var t = container.Taxis.FirstOrDefault(c => c.id == taxi.id);
                t.taxiNo = taxi.taxiNo;
                t.dateJoin = taxi.dateJoin;
                t.model = taxi.model;
                t.TaxiType = taxi.TaxiType;
                t.Group = taxi.Group;
                t.Entity = taxi.Entity;

                container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist Taxi. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

        //delete a Taxi already exist
        void TaxiModel.deleteTaxi(EntityDiagramContainer container, Taxi taxiIn)
        {
            try
            {
                var taxi = (from t in container.Taxis
                          where t.id == taxiIn.id
                          select t).FirstOrDefault();
                container.Taxis.Remove(taxi);
                container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist Taxi. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }
    }
}
