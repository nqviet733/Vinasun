using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class ReasonNoIncomeDTOImpl : ReasonNoIncomeDTO
    {

        //Create new reasonNoIncome
        int ReasonNoIncomeDTO.addReasonNoIncome(EntityDiagramContainer container, ReasonNoIncome reasonNoIncome)
        {
            int signal = 0;
            try
            {
                container.ReasonNoIncomes.Add(reasonNoIncome);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new reasonNoIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a reasonNoIncome already exist
        ReasonNoIncome ReasonNoIncomeDTO.retrieveReasonNoIncome(EntityDiagramContainer container, int reasonNoIncomeId)
        {
            ReasonNoIncome rni = null;
            try
            {
                rni = container.ReasonNoIncomes.Find(reasonNoIncomeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a reasonNoIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return rni;
        }

        //retrieve all reasonNoIncomes
        IList<ReasonNoIncome> ReasonNoIncomeDTO.retrieveAllReasonNoIncomes(EntityDiagramContainer container)
        {
            IList<ReasonNoIncome> rnis = null;
            try
            {
                rnis = container.Set<ReasonNoIncome>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list reasonNoIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (rnis == null)
                {
                    rnis = new List<ReasonNoIncome>();
                    
                }
            }
            return rnis;
        }

        //update a reasonNoIncome already exist
        int ReasonNoIncomeDTO.updateReasonNoIncome(EntityDiagramContainer container, ReasonNoIncome reasonNoIncomeIn)
        {
            int signal = 0;
            try
            {
                container.ReasonNoIncomes.FirstOrDefault(c => c.id == reasonNoIncomeIn.id);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist reasonNoIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a reasonNoIncome already exist
        int ReasonNoIncomeDTO.deleteReasonNoIncome(EntityDiagramContainer container, ReasonNoIncome reasonNoIncomeIn)
        {
            int signal = 0;
            try
            {
                var rni = (from reasonNoIncome in container.ReasonNoIncomes
                          where reasonNoIncome.id == reasonNoIncomeIn.id
                          select reasonNoIncome).FirstOrDefault();
                container.ReasonNoIncomes.Remove(rni);
                signal = container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist reasonNoIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

    }
}
