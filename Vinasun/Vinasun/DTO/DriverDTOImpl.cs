using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.DTO
{
    class DriverDTOImpl : DriverDTO
    {

        //Create new driver
        int DriverDTO.addDriver(EntityDiagramContainer container, Driver driver)
        {
            int signal = 0;
            try
            {
                container.Drivers.Add(driver);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new driver. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a driver already exist
        Driver DriverDTO.retrieveDriver(EntityDiagramContainer container, int driverId)
        {
            Driver d = null;
            try
            {
                d = container.Drivers.Find(driverId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a driver. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return d;
        }

        //retrieve all drivers
        IList<Driver> DriverDTO.retrieveAllDrivers(EntityDiagramContainer container)
        {
            IList<Driver> ds = null;
            try
            {
                ds = container.Set<Driver>().ToList();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list driver. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (ds == null)
                {
                    ds = new List<Driver>();
                }
            }
            return ds;
        }

        //update a driver already exist
        int DriverDTO.updateDriver(EntityDiagramContainer container, Driver driverIn)
        {
            int signal = 0;
            try
            {
                container.Drivers.FirstOrDefault(d => d.id == driverIn.id);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist driver. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a driver already exist
        int DriverDTO.deleteDriver(EntityDiagramContainer container, Driver driverIn)
        {
            int signal = 0;
            try
            {
                var d = (from driver in container.Drivers
                         where driver.id == driverIn.id
                         select driver).FirstOrDefault();
                container.Drivers.Remove(d);
                signal = container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist driver. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

    }
}
