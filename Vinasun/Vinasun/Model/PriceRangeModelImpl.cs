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
        int PriceRangeModel.addPriceRange(EntityDiagramContainer container, PriceRange priceRange)
        {
            int signal = 0;
            try
            {
                container.PriceRanges.Add(priceRange);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new PriceRange. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a PriceRange already exist
        PriceRange PriceRangeModel.retrievePriceRange(EntityDiagramContainer container, int priceRangeId)
        {
            PriceRange pr = null;
            try
            {
                pr = container.PriceRanges.Find(priceRangeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a PriceRange. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return pr;
        }

        //retrieve all price ranges
        IList<PriceRange> PriceRangeModel.retrieveAllPriceRanges(EntityDiagramContainer container)
        {
            IList<PriceRange> prs = null;
            try
            {
                prs = container.Set<PriceRange>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list PriceRange. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (prs == null)
                {
                    prs = new List<PriceRange>();
                }
            }
            return prs;
        }

        //update a PriceRange already exist
        int PriceRangeModel.updatePriceRange(EntityDiagramContainer container, PriceRange priceRangeIn)
        {
            int signal = 0;
            try
            {
                container.PriceRanges.FirstOrDefault(c => c.id == priceRangeIn.id);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist PriceRange. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a PriceRange already exist
        int PriceRangeModel.deletePriceRange(EntityDiagramContainer container, PriceRange priceRangeIn)
        {
            int signal = 0;
            try
            {
                var pr = (from priceRange in container.PriceRanges
                                  where priceRange.id == priceRangeIn.id
                                  select priceRange).FirstOrDefault();
                container.PriceRanges.Remove(pr);
                signal = container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist PriceRange. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

    }
}
