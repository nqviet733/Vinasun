using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class TaxiTypeModelImpl : TaxiTypeModel
    {

        //Create new TaxiType
        void TaxiTypeModel.addTaxiType(EntityDiagramContainer container, TaxiType taxiType)
        {
            try
            {
                container.TaxiTypes.Add(taxiType);
                container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new TaxiType. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

        //retrieve a TaxiType already exist
        TaxiType TaxiTypeModel.retrieveTaxiType(EntityDiagramContainer container, int taxiTypeId)
        {
            try
            {
                return container.TaxiTypes.Find(taxiTypeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a TaxiType. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //retrieve all taxi types
        IList<TaxiType> TaxiTypeModel.retrieveAllTaxiTypes(EntityDiagramContainer container)
        {
            try
            {
                return container.Set<TaxiType>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list TaxiType. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return null;
        }

        //update a TaxiType already exist
        void TaxiTypeModel.updateTaxiType(EntityDiagramContainer container, TaxiType taxiTypeIn)
        {
            try
            {
                var taxiType = container.TaxiTypes.FirstOrDefault(c => c.id == taxiTypeIn.id);
                taxiType.description = taxiTypeIn.description;
                taxiType.symbol = taxiTypeIn.symbol;

                container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist TaxiType. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

        //delete a TaxiType already exist
        void TaxiTypeModel.deleteTaxiType(EntityDiagramContainer container, TaxiType taxiTypeIn)
        {
            try
            {
                var ttt = (from taxiType in container.TaxiTypes
                                where taxiType.id == taxiTypeIn.id
                                select taxiType).FirstOrDefault();
                container.TaxiTypes.Remove(ttt);
                container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist TaxiType. Try again, and if the problem persists see your system administrator: " + ex);
            }
        }

    }
}
