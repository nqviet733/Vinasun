using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class SubtractionIncomeDTOImpl : SubtractionIncomeDTO
    {

        //Create new SubtractionIncome
        int SubtractionIncomeDTO.addSubtractionIncome(EntityDiagramContainer container, SubtractionIncome subtractionIncome)
        {
            int signal = 0;
            try
            {
                container.SubtractionIncomes.Add(subtractionIncome);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new SubtractionIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a SubtractionIncome already exist
        SubtractionIncome SubtractionIncomeDTO.retrieveSubtractionIncome(EntityDiagramContainer container, int subtractionIncomeId)
        {
            SubtractionIncome si = null;
            try
            {
                si = container.SubtractionIncomes.Find(subtractionIncomeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a SubtractionIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return si;
        }

        //retrieve all user roles
        IList<SubtractionIncome> SubtractionIncomeDTO.retrieveAllSubtractionIncomes(EntityDiagramContainer container)
        {
            IList<SubtractionIncome> sis = null;
            try
            {
                sis = container.Set<SubtractionIncome>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list SubtractionIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (sis == null)
                {
                    sis = new List<SubtractionIncome>();
                }
            }
            return sis;
        }

        //update a SubtractionIncome already exist
        int SubtractionIncomeDTO.updateSubtractionIncome(EntityDiagramContainer container, SubtractionIncome subtractionIncomeIn)
        {
            int signal = 0;
            try
            {
                container.SubtractionIncomes.FirstOrDefault(c => c.id == subtractionIncomeIn.id);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist SubtractionIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a SubtractionIncome already exist
        int SubtractionIncomeDTO.deleteSubtractionIncome(EntityDiagramContainer container, SubtractionIncome subtractionIncomeIn)
        {
            int signal = 0;
            try
            {
                var si = (from subtractionIncome in container.SubtractionIncomes
                          where subtractionIncome.id == subtractionIncomeIn.id
                          select subtractionIncome).FirstOrDefault();
                container.SubtractionIncomes.Remove(si);
                signal = container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist SubtractionIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

    }
}
