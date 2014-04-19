using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.DTO
{
    interface DriverDTO
    {

        int addDriver(EntityDiagramContainer container, Driver driver);
        Driver retrieveDriver(EntityDiagramContainer container, int driverId);
        IList<Driver> retrieveAllDrivers(EntityDiagramContainer container);
        int updateDriver(EntityDiagramContainer container, Driver driver);
        int deleteDriver(EntityDiagramContainer container, Driver driver);

    }
}
