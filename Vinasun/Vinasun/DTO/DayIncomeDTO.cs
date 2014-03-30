using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface DayIncomeDTO
    {

        int addDayIncome(EntityDiagramContainer container, DayIncome dayIncome);
        DayIncome retrieveDayIncome(EntityDiagramContainer container, int dayIncomeId);
        IList<DayIncome> retrieveAllDayIncomes(EntityDiagramContainer container);
        int updateDayIncome(EntityDiagramContainer container, DayIncome dayIncome);
        int deleteDayIncome(EntityDiagramContainer container, DayIncome dayIncome);

    }
}
