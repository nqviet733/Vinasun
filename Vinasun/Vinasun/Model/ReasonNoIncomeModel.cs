using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface ReasonNoIncomeModel
    {

        int addReasonNoIncome(EntityDiagramContainer container, ReasonNoIncome reasonNoIncome);
        ReasonNoIncome retrieveReasonNoIncome(EntityDiagramContainer container, int reasonNoIncomeId);
        IList<ReasonNoIncome> retrieveAllReasonNoIncomes(EntityDiagramContainer container);
        int updateReasonNoIncome(EntityDiagramContainer container, ReasonNoIncome reasonNoIncome);
        int deleteReasonNoIncome(EntityDiagramContainer container, ReasonNoIncome reasonNoIncome);

    }
}
