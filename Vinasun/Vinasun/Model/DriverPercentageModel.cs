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
    class DriverPercentageModel
    {
        public void showDGV(DataGridViewX dgv, EntityDiagramContainer entitiesContainer)
        {
            DriverPercentangeDTO driverPercentangeDTO = new DriverPercentangeDTOImpl();
            IList<DriverPercentange> driverPercentanges = driverPercentangeDTO.retrieveAllDriverPercentanges(entitiesContainer);
            dgv.DataSource = null;
            dgv.DataSource = driverPercentanges;
            dgv.Columns["id"].HeaderText = "ID";
            dgv.Columns["id"].Visible = false;
            //dgv.Columns["name"].HeaderText = "Tên Nhánh";
            //dgv.Columns["created"].HeaderText = "Ngày Thêm";
        }
    }
}
