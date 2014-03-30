using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface SubtractionIncomeModel
    {

        int addSubtractionIncome(EntityDiagramContainer container, SubtractionIncome subtractionIncome);
        SubtractionIncome retrieveSubtractionIncome(EntityDiagramContainer container, int subtractionIncomeId);
        IList<SubtractionIncome> retrieveAllSubtractionIncomes(EntityDiagramContainer container);
        int updateSubtractionIncome(EntityDiagramContainer container, SubtractionIncome subtractionIncome);
        int deleteSubtractionIncome(EntityDiagramContainer container, SubtractionIncome subtractionIncome);

    }
}
