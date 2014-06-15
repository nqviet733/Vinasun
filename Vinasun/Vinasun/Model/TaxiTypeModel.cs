﻿using System;
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
    class TaxiTypeModel
    {
        public void showDGV(DataGridViewX dgv, EntityDiagramContainer entitiesContainer)
        {
            TaxiTypeDTO taxiTypeDTO = new TaxiTypeDTOImpl();
            IList<TaxiType> taxiTypes = taxiTypeDTO.retrieveAllTaxiTypes(entitiesContainer);
            dgv.DataSource = null;
            dgv.DataSource = taxiTypes;
            dgv.Columns["id"].HeaderText = "ID";
            dgv.Columns["id"].Visible = false;
            dgv.Columns["symbol"].HeaderText = "Kí Hiệu";
            dgv.Columns["description"].HeaderText = "Mô Tả Xe";
        }

        public Dictionary<int, string> getTaxiTypes(EntityDiagramContainer entitiesContainer)
        {
            Dictionary<int, string> taxiTypes = new Dictionary<int, string>();
            TaxiTypeDTO taxiTypeDTO = new TaxiTypeDTOImpl();
            foreach (TaxiType taxiType in taxiTypeDTO.retrieveAllTaxiTypes(entitiesContainer))
            {
                taxiTypes.Add(taxiType.id, taxiType.symbol);
            }
            return taxiTypes;
        }

    }
}
