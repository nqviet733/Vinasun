using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface RepairCostModel
    {

        int addRepairCost(EntityDiagramContainer container, RepairCost repairCost);
        RepairCost retrieveRepairCost(EntityDiagramContainer container, int repairCostId);
        IList<RepairCost> retrieveAllRepairCosts(EntityDiagramContainer container);
        int updateRepairCost(EntityDiagramContainer container, RepairCost repairCost);
        int deleteRepairCost(EntityDiagramContainer container, RepairCost repairCost);

    }
}
