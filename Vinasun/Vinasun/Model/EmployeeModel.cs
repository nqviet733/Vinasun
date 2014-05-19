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
    class EmployeeModel
    {
        public void showDGV(DataGridViewX dgv, EntityDiagramContainer entitiesContainer)
        {
            EntityDTO entityDTO = new EntityDTOImpl();
            IList<Entity> entities = entityDTO.retrieveAllEntities(entitiesContainer);
            dgv.DataSource = null;
            dgv.DataSource = entities;
            dgv.Columns["id"].HeaderText = "ID";
            dgv.Columns["id"].Visible = false;
            dgv.Columns["firstName"].HeaderText = "Tên";
            dgv.Columns["lastName"].HeaderText = "Họ";
            dgv.Columns["gender"].HeaderText = "Giới Tính";
            dgv.Columns["email"].HeaderText = "Email";
            dgv.Columns["businessPhone"].HeaderText = "Đi Động";
            dgv.Columns["dateJoin"].HeaderText = "Ngày Vào Đội";
            dgv.Columns["entityNo"].HeaderText = "Mã Nhân Viên";
        }
    }
}
