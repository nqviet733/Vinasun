using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.DTO
{
    class BranchDTOImpl:BranchDTO
    {

        //Create new branch
        int BranchDTO.addBranch(EntityDiagramContainer container, Branch branch)
        {
            int signal = 0;
            try
            {
                container.Branches.Add(branch);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new branch. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a branch already exist
        Branch BranchDTO.retrieveBranch(EntityDiagramContainer container, int branchId)
        {
            Branch d = null;
            try
            {
                d = container.Branches.Find(branchId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a branch. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return d;
        }

        //retrieve all branchs
        IList<Branch> BranchDTO.retrieveAllBranches(EntityDiagramContainer container)
        {
            IList<Branch> ds = null;
            try
            {
                ds = container.Set<Branch>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list branch. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (ds == null)
                {
                    ds = new List<Branch>();
                }
            }
            return ds;
        }

        //update a branch already exist
        int BranchDTO.updateBranch(EntityDiagramContainer container, Branch branchIn)
        {
            int signal = 0;
            try
            {
                container.Branches.FirstOrDefault(d => d.id == branchIn.id);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist branch. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a branch already exist
        int BranchDTO.deleteBranch(EntityDiagramContainer container, Branch branchIn)
        {
            int signal = 0;
            try
            {
                var d = (from branch in container.Branches
                         where branch.id == branchIn.id
                         select branch).FirstOrDefault();
                container.Branches.Remove(d);
                signal = container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist branch. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

    }
}
