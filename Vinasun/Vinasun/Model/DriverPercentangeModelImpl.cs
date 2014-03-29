using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class DriverPercentangeModelImpl : DriverPercentangeModel
    {

        //Create new DriverPercentange
        void DriverPercentangeModel.addDriverPercentange(EntityDiagramContainer container, DriverPercentange driverPercentange)
        {
            try
            {
                container.DriverPercentanges.Add(driverPercentange);
                container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new DriverPercentange. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

        //retrieve a DriverPercentange already exist
        DriverPercentange DriverPercentangeModel.retrieveDriverPercentange(EntityDiagramContainer container, int driverPercentangeId)
        {
            try
            {
                return container.DriverPercentanges.Find(driverPercentangeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a DriverPercentange. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //retrieve all driver Percentange
        IList<DriverPercentange> DriverPercentangeModel.retrieveAllDriverPercentanges(EntityDiagramContainer container)
        {
            try
            {
                return container.Set<DriverPercentange>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list DriverPercentange. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //update a DriverPercentange already exist
        void DriverPercentangeModel.updateDriverPercentange(EntityDiagramContainer container, DriverPercentange driverPercentangeIn)
        {
            try
            {
                var driverPercentange = container.DriverPercentanges.FirstOrDefault(c => c.id == driverPercentangeIn.id);
                driverPercentange.percent = driverPercentangeIn.percent;
                driverPercentange.PriceRange = driverPercentangeIn.PriceRange;
                driverPercentange.TaxiType = driverPercentangeIn.TaxiType;

                container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist DriverPercentange. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

        //delete a DriverPercentange already exist
        void DriverPercentangeModel.deleteDriverPercentange(EntityDiagramContainer container, DriverPercentange driverPercentangeIn)
        {
            try
            {
                var dp = (from driverPercentange in container.DriverPercentanges
                                         where driverPercentange.id == driverPercentangeIn.id
                                         select driverPercentange).FirstOrDefault();
                container.DriverPercentanges.Remove(dp);
                container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist DriverPercentange. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }
    }
}
