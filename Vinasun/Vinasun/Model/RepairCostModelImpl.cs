using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class RepairCostModelImpl : RepairCostModel
    {

        //Create new repairCost
        int RepairCostModel.addRepairCost(EntityDiagramContainer container, RepairCost repairCost)
        {
            int signal = 0;
            try
            {
                container.RepairCosts.Add(repairCost);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new repairCost. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a repairCost already exist
        RepairCost RepairCostModel.retrieveRepairCost(EntityDiagramContainer container, int repairCostId)
        {
            RepairCost rc = null;
            try
            {
                rc =  container.RepairCosts.Find(repairCostId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a repairCost. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return rc;
        }

        //retrieve all repairCosts
        IList<RepairCost> RepairCostModel.retrieveAllRepairCosts(EntityDiagramContainer container)
        {
            IList<RepairCost> rcs = null;
            try
            {
                rcs = container.Set<RepairCost>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list repairCost. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (rcs == null)
                {
                    rcs = new List<RepairCost>();
                }
            }
            return rcs;
        }

        //update a repairCost already exist
        int RepairCostModel.updateRepairCost(EntityDiagramContainer container, RepairCost repairCostIn)
        {
            int signal = 0;
            try
            {
                container.RepairCosts.FirstOrDefault(c => c.id == repairCostIn.id);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist repairCost. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a repairCost already exist
        int RepairCostModel.deleteRepairCost(EntityDiagramContainer container, RepairCost repairCostIn)
        {
            int signal = 0;
            try
            {
                var rc = (from repairCost in container.RepairCosts
                          where repairCost.id == repairCostIn.id
                          select repairCost).FirstOrDefault();
                container.RepairCosts.Remove(rc);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist repairCost. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

    }
}
