using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class TripCheckModelImpl : TripCheckModel
    {

        //Create new TripCheck
        int TripCheckModel.addTripCheck(EntityDiagramContainer container, TripCheck tripCheck)
        {
            int signal = 0;
            try
            {
                container.TripChecks.Add(tripCheck);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new TripCheck. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a TripCheck already exist
        TripCheck TripCheckModel.retrieveTripCheck(EntityDiagramContainer container, int tripCheckId)
        {
            TripCheck tc = null;
            try
            {
                tc = container.TripChecks.Find(tripCheckId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a TripCheck. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return tc;
        }

        //retrieve all user roles
        IList<TripCheck> TripCheckModel.retrieveAllTripChecks(EntityDiagramContainer container)
        {
            IList<TripCheck> tcs = null;
            try
            {
                tcs = container.Set<TripCheck>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list TripCheck. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (tcs == null)
                {
                    tcs = new List<TripCheck>();
                }
            }
            return tcs;
        }

        //update a TripCheck already exist
        int TripCheckModel.updateTripCheck(EntityDiagramContainer container, TripCheck tripCheckIn)
        {
            int signal = 0;
            try
            {
                container.TripChecks.FirstOrDefault(c => c.id == tripCheckIn.id);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist TripCheck. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a TripCheck already exist
        int TripCheckModel.deleteTripCheck(EntityDiagramContainer container, TripCheck tripCheckIn)
        {
            int signal = 0;
            try
            {
                var tc = (from tripCheck in container.TripChecks
                          where tripCheck.id == tripCheckIn.id
                          select tripCheck).FirstOrDefault();
                container.TripChecks.Remove(tc);
                signal = container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist TripCheck. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

    }
}
