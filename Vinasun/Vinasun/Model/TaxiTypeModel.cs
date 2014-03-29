using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface TaxiTypeModel
    {

        void addTaxiType(EntityDiagramContainer container, TaxiType taxiType);
        TaxiType retrieveTaxiType(EntityDiagramContainer container, int taxiTypeId);
        IList<TaxiType> retrieveAllTaxiTypes(EntityDiagramContainer container);
        void updateTaxiType(EntityDiagramContainer container, TaxiType taxiType);
        void deleteTaxiType(EntityDiagramContainer container, TaxiType taxiType);

    }
}
