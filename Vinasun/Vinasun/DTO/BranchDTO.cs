using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.DTO
{
    interface BranchDTO
    {

        int addBranch(EntityDiagramContainer container, Branch branch);
        Branch retrieveBranch(EntityDiagramContainer container, int branchId);
        IList<Branch> retrieveAllBranches(EntityDiagramContainer container);
        int updateBranch(EntityDiagramContainer container, Branch branch);
        int deleteBranch(EntityDiagramContainer container, Branch branch);

    }
}
