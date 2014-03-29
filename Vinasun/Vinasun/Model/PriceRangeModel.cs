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

        void addPriceRange(EntityDiagramContainer container, PriceRange priceRange);
        PriceRange retrievePriceRange(EntityDiagramContainer container, int priceRangeId);
        IList<PriceRange> retrieveAllPriceRanges(EntityDiagramContainer container);
        void updatePriceRange(EntityDiagramContainer container, PriceRange priceRange);
        void deletePriceRange(EntityDiagramContainer container, PriceRange priceRange);

    }
}
