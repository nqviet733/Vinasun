using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class DayIncomeModelImpl : DayIncomeModel
    {

        //Create new dayIncome
        int DayIncomeModel.addDayIncome(EntityDiagramContainer container, DayIncome dayIncome)
        {
            int signal = 0;
            try
            {
                container.DayIncomes.Add(dayIncome);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new dayIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a dayIncome already exist
        DayIncome DayIncomeModel.retrieveDayIncome(EntityDiagramContainer container, int dayIncomeId)
        {
            DayIncome di = null;
            try
            {
                di = container.DayIncomes.Find(dayIncomeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a dayIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return di;
        }

        //retrieve all dayIncomes
        IList<DayIncome> DayIncomeModel.retrieveAllDayIncomes(EntityDiagramContainer container)
        {
            IList<DayIncome> dis = null;
            try
            {
                dis = container.Set<DayIncome>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list dayIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (dis == null)
                {
                    dis = new List<DayIncome>();
                }
            }
            return dis;
        }

        //update a dayIncome already exist
        int DayIncomeModel.updateDayIncome(EntityDiagramContainer container, DayIncome dayIncomeIn)
        {
            int signal = 0;
            try
            {
                var dayIncome = container.DayIncomes.FirstOrDefault(c => c.id == dayIncomeIn.id);

                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist dayIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a dayIncome already exist
        int DayIncomeModel.deleteDayIncome(EntityDiagramContainer container, DayIncome dayIncomeIn)
        {
            int signal = 0;
            try
            {
                var di = (from dayIncome in container.DayIncomes
                         where dayIncome.id == dayIncomeIn.id
                         select dayIncome).FirstOrDefault();
                container.DayIncomes.Remove(di);
                signal = container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist dayIncome. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

    }
}
