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
    class TaxiModel
    {
        public void showDGV(DataGridViewX dgv, EntityDiagramContainer entitiesContainer)
        {
            TaxiDTO entityDTO = new TaxiDTOImpl();
            IList<Taxi> entities = entityDTO.retrieveAllTaxis(entitiesContainer);
            dgv.DataSource = null;
            dgv.DataSource = entities;
            dgv.Columns["id"].HeaderText = "ID";
            dgv.Columns["id"].Visible = false;
            dgv.Columns["taxiNo"].HeaderText = "Biển Số Xe";
            dgv.Columns["dateJoin"].HeaderText = "Ngày Ra Đội";
            dgv.Columns["model"].HeaderText = "Model";
            dgv.Columns["driverNoMain"].HeaderText = "Số Tài Chính";
            dgv.Columns["TaxiType"].HeaderText = "Loại Xe";
            dgv.Columns["Group"].HeaderText = "Đội Xe";
        }

        public Dictionary<int, string> getMainDrivers(EntityDiagramContainer entitiesContainer)
        {
            Dictionary<int, string> mainDrivers = new Dictionary<int, string>();
            TaxiDTO taxiDTO = new TaxiDTOImpl();
            foreach (Taxi taxi in taxiDTO.retrieveAllTaxis(entitiesContainer))
            {
                mainDrivers.Add(taxi.id, taxi.driverNoMain);
            }
            return mainDrivers;
        }
    }
}
