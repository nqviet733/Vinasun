using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface TripCheckModel
    {

        int addTripCheck(EntityDiagramContainer container, TripCheck tripCheck);
        TripCheck retrieveTripCheck(EntityDiagramContainer container, int tripCheckId);
        IList<TripCheck> retrieveAllTripChecks(EntityDiagramContainer container);
        int updateTripCheck(EntityDiagramContainer container, TripCheck tripCheck);
        int deleteTripCheck(EntityDiagramContainer container, TripCheck tripCheck);

    }
}
