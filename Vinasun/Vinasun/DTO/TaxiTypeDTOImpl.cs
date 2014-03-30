using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class TaxiTypeDTOImpl : TaxiTypeDTO
    {

        //Create new TaxiType
        int TaxiTypeDTO.addTaxiType(EntityDiagramContainer container, TaxiType taxiType)
        {
            int signal = 0;
            try
            {
                container.TaxiTypes.Add(taxiType);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new TaxiType. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a TaxiType already exist
        TaxiType TaxiTypeDTO.retrieveTaxiType(EntityDiagramContainer container, int taxiTypeId)
        {
            TaxiType tt = null;
            try
            {
                tt = container.TaxiTypes.Find(taxiTypeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a TaxiType. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return tt;
        }

        //retrieve all taxi types
        IList<TaxiType> TaxiTypeDTO.retrieveAllTaxiTypes(EntityDiagramContainer container)
        {
            IList<TaxiType> tts = null;
            try
            {
                tts = container.Set<TaxiType>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list TaxiType. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (tts == null)
                {
                    tts = new List<TaxiType>();
                }
            }
            return tts;
        }

        //update a TaxiType already exist
        int TaxiTypeDTO.updateTaxiType(EntityDiagramContainer container, TaxiType taxiTypeIn)
        {
            int signal = 0;
            try
            {
                container.TaxiTypes.FirstOrDefault(c => c.id == taxiTypeIn.id);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist TaxiType. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a TaxiType already exist
        int TaxiTypeDTO.deleteTaxiType(EntityDiagramContainer container, TaxiType taxiTypeIn)
        {
            int signal = 0;
            try
            {
                var ttt = (from taxiType in container.TaxiTypes
                                where taxiType.id == taxiTypeIn.id
                                select taxiType).FirstOrDefault();
                container.TaxiTypes.Remove(ttt);
                signal = container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist TaxiType. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

    }
}
