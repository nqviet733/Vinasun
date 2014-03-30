using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class TaxiModelImpl:TaxiModel
    {

        //Create new Taxi
        int TaxiModel.addTaxi(EntityDiagramContainer container, Taxi taxi)
        {
            int signal = 0;
            try
            {
                container.Taxis.Add(taxi);
                signal = container.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unable to add new Taxi. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a Taxi already exist
        Taxi TaxiModel.retrieveTaxi(EntityDiagramContainer container, int taxiId)
        {
            Taxi t = null;
            try
            {
                t = container.Taxis.Find(taxiId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a Taxi. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return t;
        }

        //retrieve all Taxis
        IList<Taxi> TaxiModel.retrieveAllTaxis(EntityDiagramContainer container)
        {
            IList<Taxi> txs = null;
            try
            {
                txs = container.Set<Taxi>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list Taxi. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (txs == null)
                {
                    txs = new List<Taxi>();
                }
            }
            return txs;
        }

        //update a Taxi already exist
        int TaxiModel.updateTaxi(EntityDiagramContainer container, Taxi taxi)
        {
            int signal = 0;
            try
            {
                container.Taxis.FirstOrDefault(c => c.id == taxi.id);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist Taxi. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a Taxi already exist
        int TaxiModel.deleteTaxi(EntityDiagramContainer container, Taxi taxiIn)
        {
            int signal = 0;
            try
            {
                var tx = (from taxi in container.Taxis
                            where taxi.id == taxiIn.id
                            select taxi).FirstOrDefault();
                container.Taxis.Remove(tx);
                signal = container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist Taxi. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

    }
}
