using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface TaxiModel
    {

        int addTaxi(EntityDiagramContainer container, Taxi taxi);
        Taxi retrieveTaxi(EntityDiagramContainer container, int taxiId);
        IList<Taxi> retrieveAllTaxis(EntityDiagramContainer container);
        int updateTaxi(EntityDiagramContainer container, Taxi taxi);
        int deleteTaxi(EntityDiagramContainer container, Taxi taxi);

    }
}
