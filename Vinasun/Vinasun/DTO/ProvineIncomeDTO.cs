using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface ProvineIncomeDTO
    {

        int addProvineIncome(EntityDiagramContainer container, ProvineIncome provineIncome);
        ProvineIncome retrieveProvineIncome(EntityDiagramContainer container, int provineIncomeId);
        IList<ProvineIncome> retrieveAllProvineIncomes(EntityDiagramContainer container);
        int updateProvineIncome(EntityDiagramContainer container, ProvineIncome provineIncome);
        int deleteProvineIncome(EntityDiagramContainer container, ProvineIncome provineIncome);

    }
}
