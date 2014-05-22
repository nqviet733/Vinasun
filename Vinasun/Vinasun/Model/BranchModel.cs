using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;
using Vinasun.View;
using Vinasun.DTO;
using DevComponents.DotNetBar.Controls;

namespace Vinasun.Model
{
    class BranchModel
    {
        public void showDGV(DataGridViewX dgv, EntityDiagramContainer entitiesContainer)
        {
            BranchDTO branchDTO = new BranchDTOImpl();
            IList<Branch> branches = branchDTO.retrieveAllBranches(entitiesContainer);
            dgv.DataSource = null;
            dgv.DataSource = branches;
            dgv.Columns["id"].HeaderText = "ID";
            dgv.Columns["id"].Visible = false;
            dgv.Columns["name"].HeaderText = "Tên Nhánh";
            dgv.Columns["created"].HeaderText = "Ngày Thêm";
        }
        public Dictionary<int, string> getBranchTypes(EntityDiagramContainer entitiesContainer)
        {
            Dictionary<int, string> branchTypes = new Dictionary<int, string>();
            BranchDTO branchDTO = new BranchDTOImpl();
            foreach (Branch branch in branchDTO.retrieveAllBranches(entitiesContainer))
            {
                branchTypes.Add(branch.id, branch.name);
            }
            return branchTypes;
        }

        public IList<Branch> getBranchTypes1(EntityDiagramContainer entitiesContainer)
        {
            BranchDTO branchDTO = new BranchDTOImpl();
            return branchDTO.retrieveAllBranches(entitiesContainer);
        }
    }
}
