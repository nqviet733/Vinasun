using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinasun.Model
{
    interface TaxiModel
    {
        void addTaxi(EntityDiagramContainer container, Taxi taxi);
        Taxi retrieveGroup(EntityDiagramContainer container, int groupId);
        IList<Taxi> retrieveAllGroup(EntityDiagramContainer container);
        void updateGroup(EntityDiagramContainer container, Taxi group);
        void deleteGroup(EntityDiagramContainer container, Taxi group);
    }
}
