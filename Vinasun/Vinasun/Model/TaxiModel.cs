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

        void addTaxi(EntityDiagramContainer container, Taxi taxi);
        Taxi retrieveTaxi(EntityDiagramContainer container, int taxiId);
        IList<Taxi> retrieveAllTaxis(EntityDiagramContainer container);
        void updateTaxi(EntityDiagramContainer container, Taxi taxi);
        void deleteTaxi(EntityDiagramContainer container, Taxi taxi);

    }
}
