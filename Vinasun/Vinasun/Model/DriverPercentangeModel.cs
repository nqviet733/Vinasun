using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface DriverPercentangeModel
    {

        void addDriverPercentange(EntityDiagramContainer container, DriverPercentange driverPercentange);
        DriverPercentange retrieveDriverPercentange(EntityDiagramContainer container, int driverPercentangeId);
        IList<DriverPercentange> retrieveAllDriverPercentanges(EntityDiagramContainer container);
        void updateDriverPercentange(EntityDiagramContainer container, DriverPercentange driverPercentange);
        void deleteDriverPercentange(EntityDiagramContainer container, DriverPercentange driverPercentange);

    }
}
