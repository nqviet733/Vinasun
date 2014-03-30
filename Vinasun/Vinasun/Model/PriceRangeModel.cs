using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface PriceRangeModel
    {

        int addPriceRange(EntityDiagramContainer container, PriceRange priceRange);
        PriceRange retrievePriceRange(EntityDiagramContainer container, int priceRangeId);
        IList<PriceRange> retrieveAllPriceRanges(EntityDiagramContainer container);
        int updatePriceRange(EntityDiagramContainer container, PriceRange priceRange);
        int deletePriceRange(EntityDiagramContainer container, PriceRange priceRange);

    }
}
