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

        int addTaxiType(EntityDiagramContainer container, TaxiType taxiType);
        TaxiType retrieveTaxiType(EntityDiagramContainer container, int taxiTypeId);
        IList<TaxiType> retrieveAllTaxiTypes(EntityDiagramContainer container);
        int updateTaxiType(EntityDiagramContainer container, TaxiType taxiType);
        int deleteTaxiType(EntityDiagramContainer container, TaxiType taxiType);

    }
}
