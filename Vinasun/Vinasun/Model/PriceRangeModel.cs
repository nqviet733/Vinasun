using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;
using Vinasun.View;
using Vinasun.DTO;
using DevComponents.DotNetBar.Controls;
using Vinasun.Enum;

namespace Vinasun.Model
{
    class PriceRangeModel
    {
        public void showDGV(DataGridViewX dgv, EntityDiagramContainer entitiesContainer)
        {
            PriceRangeDTO priceRangeDTO = new PriceRangeDTOImpl();
            IList<PriceRange> priceRanges = priceRangeDTO.retrieveAllPriceRanges(entitiesContainer);
            dgv.DataSource = null;
            dgv.DataSource = priceRanges;
            dgv.Columns["id"].HeaderText = "ID";
            dgv.Columns["id"].Visible = false;
            //dgv.Columns["name"].HeaderText = "Tên Nhánh";
            //dgv.Columns["created"].HeaderText = "Ngày Thêm";
        }

        public Dictionary<int, string> getPriceRanges(EntityDiagramContainer entitiesContainer)
        {
            Dictionary<int, string> priceRanges = new Dictionary<int, string>();
            PriceRangeDTO priceRangeDTO = new PriceRangeDTOImpl();
            foreach (PriceRange priceRange in priceRangeDTO.retrieveAllPriceRanges(entitiesContainer))
            {
                priceRanges.Add(priceRange.id, "Giá từ "+priceRange.start + " đến " + priceRange.end);
            }
            return priceRanges;
        }
    }
}
