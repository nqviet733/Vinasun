using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class ProvineIncomeModelImpl : ProvineIncomeModel
    {

        //Create new ProvineIncome
        int ProvineIncomeModel.addProvineIncome(EntityDiagramContainer container, ProvineIncome provineIncome)
        {
            int signal = 0;
            try
            {
                container.ProvineIncomes.Add(provineIncome);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new ProvineIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a ProvineIncome already exist
        ProvineIncome ProvineIncomeModel.retrieveProvineIncome(EntityDiagramContainer container, int provineIncomeId)
        {
            ProvineIncome pi = null;
            try
            {
                pi = container.ProvineIncomes.Find(provineIncomeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a ProvineIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return pi;
        }

        //retrieve all user roles
        IList<ProvineIncome> ProvineIncomeModel.retrieveAllProvineIncomes(EntityDiagramContainer container)
        {
            IList<ProvineIncome> pis = null;
            try
            {
                pis = container.Set<ProvineIncome>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list ProvineIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (pis == null)
                {
                    pis = new List<ProvineIncome>();
                }
            }
            return pis;
        }

        //update a ProvineIncome already exist
        int ProvineIncomeModel.updateProvineIncome(EntityDiagramContainer container, ProvineIncome provineIncomeIn)
        {
            int signal = 0;
            try
            {
                container.ProvineIncomes.FirstOrDefault(c => c.id == provineIncomeIn.id);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist ProvineIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a ProvineIncome already exist
        int ProvineIncomeModel.deleteProvineIncome(EntityDiagramContainer container, ProvineIncome provineIncomeIn)
        {
            int signal = 0;
            try
            {
                var pi = (from provineIncome in container.ProvineIncomes
                          where provineIncome.id == provineIncomeIn.id
                          select provineIncome).FirstOrDefault();
                container.ProvineIncomes.Remove(pi);
                signal = container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist ProvineIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

    }
}
