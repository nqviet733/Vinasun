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
    class Employee
    {
        public void showDGV(DataGridViewX dgv, EntityDiagramContainer entitiesContainer)
        {
            EntityDTO entityDTO = new EntityDTOImpl();
            IList<Entity> entities = entityDTO.retrieveAllEntities(entitiesContainer);
            dgv.DataSource = entities;
            dgv.Columns["id"].HeaderText = "ID";
            dgv.Columns["firstName"].HeaderText = "Tên";
        }
    }
}
