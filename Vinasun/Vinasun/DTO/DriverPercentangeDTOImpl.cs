using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class DriverPercentangeDTOImpl : DriverPercentangeDTO
    {

        //Create new DriverPercentange
        int DriverPercentangeDTO.addDriverPercentange(EntityDiagramContainer container, DriverPercentange driverPercentange)
        {
            int signal = 0;
            try
            {
                container.DriverPercentanges.Add(driverPercentange);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new DriverPercentange. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a DriverPercentange already exist
        DriverPercentange DriverPercentangeDTO.retrieveDriverPercentange(EntityDiagramContainer container, int driverPercentangeId)
        {
            DriverPercentange dp = null;
            try
            {
                dp = container.DriverPercentanges.Find(driverPercentangeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a DriverPercentange. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return dp;
        }

        //retrieve all driver Percentange
        IList<DriverPercentange> DriverPercentangeDTO.retrieveAllDriverPercentanges(EntityDiagramContainer container)
        {
            IList<DriverPercentange> dps = null;
            try
            {
                dps = container.Set<DriverPercentange>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list DriverPercentange. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (dps == null)
                {
                    dps = new List<DriverPercentange>();
                }
            }
            return dps;
        }

        //update a DriverPercentange already exist
        int DriverPercentangeDTO.updateDriverPercentange(EntityDiagramContainer container, DriverPercentange driverPercentangeIn)
        {
            int signal = 0;
            try
            {
                container.DriverPercentanges.FirstOrDefault(c => c.id == driverPercentangeIn.id);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist DriverPercentange. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a DriverPercentange already exist
        int DriverPercentangeDTO.deleteDriverPercentange(EntityDiagramContainer container, DriverPercentange driverPercentangeIn)
        {
            int signal = 0;
            try
            {
                var dp = (from driverPercentange in container.DriverPercentanges
                                         where driverPercentange.id == driverPercentangeIn.id
                                         select driverPercentange).FirstOrDefault();
                container.DriverPercentanges.Remove(dp);
                signal = container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist DriverPercentange. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }
    }
}
