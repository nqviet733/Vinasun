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
    class GroupModel
    {
        public void showDGV(DataGridViewX dgv, EntityDiagramContainer entitiesContainer)
        {
            GroupDTO branchDTO = new GroupDTOImpl();
            IList<Group> branches = branchDTO.retrieveAllGroups(entitiesContainer);
            dgv.DataSource = null;
            dgv.DataSource = branches;
            dgv.Columns["id"].HeaderText = "ID";
            dgv.Columns["id"].Visible = false;
            //dgv.Columns["name"].HeaderText = "Tên Nhánh";
            //dgv.Columns["created"].HeaderText = "Ngày Thêm";
        }
        public Dictionary<int, string> getGroupNames(EntityDiagramContainer entitiesContainer)
        {
            Dictionary<int, string> groupNames = new Dictionary<int, string>();
            GroupDTO groupDTO = new GroupDTOImpl();
            foreach (Group group in groupDTO.retrieveAllGroups(entitiesContainer))
            {
                groupNames.Add(group.id, group.name);
            }
            return groupNames;
        }
    }
}
