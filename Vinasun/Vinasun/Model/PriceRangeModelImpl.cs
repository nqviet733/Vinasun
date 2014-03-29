using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class PriceRangeModelImpl : PriceRangeModel
    {

        //Create new PriceRange
        void PriceRangeModel.addPriceRange(EntityDiagramContainer container, PriceRange priceRange)
        {
            try
            {
                container.PriceRanges.Add(priceRange);
                container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new PriceRange. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

        //retrieve a PriceRange already exist
        PriceRange PriceRangeModel.retrievePriceRange(EntityDiagramContainer container, int priceRangeId)
        {
            try
            {
                return container.PriceRanges.Find(priceRangeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a PriceRange. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //retrieve all price ranges
        IList<PriceRange> PriceRangeModel.retrieveAllPriceRanges(EntityDiagramContainer container)
        {
            try
            {
                return container.Set<PriceRange>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list PriceRange. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //update a PriceRange already exist
        void PriceRangeModel.updatePriceRange(EntityDiagramContainer container, PriceRange priceRangeIn)
        {
            try
            {
                var priceRange = container.PriceRanges.FirstOrDefault(c => c.id == priceRangeIn.id);
                priceRange.start = priceRangeIn.start;
                priceRange.end = priceRangeIn.end;

                container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist PriceRange. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

        //delete a PriceRange already exist
        void PriceRangeModel.deletePriceRange(EntityDiagramContainer container, PriceRange priceRangeIn)
        {
            try
            {
                var priceRange = (from PriceRange in container.PriceRanges
                                where PriceRange.id == priceRangeIn.id
                                select PriceRange).FirstOrDefault();
                container.PriceRanges.Remove(priceRange);
                container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist PriceRange. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

    }
}
