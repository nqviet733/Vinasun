using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vinasun.CommonClass;
using Vinasun.Model;
using Vinasun.EntityClass;

namespace Vinasun.View
{
    public partial class AddListEntities : Form
    {

        Vinasun.CommonClass.EventHandler eventHandler;
        Validation validatior;
        EntityDiagramContainer entitiesContainer;

        public AddListEntities()
        {
            InitializeComponent();

            eventHandler = new Vinasun.CommonClass.EventHandler();
            validatior = new Validation();
            validatior.isNotEmptyForNewCell(dataGridViewAddListEntities, 0, 10);
            entitiesContainer = new EntityDiagramContainer();
        }

        private void cellValidatingEvent(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void dataGridViewAddListEntities_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void dataGridViewAddListEntities_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cellValidatedEvent(object sender, DataGridViewCellEventArgs e)
        {
            validatior.isNotEmptyForCell(sender, e.RowIndex, e.ColumnIndex);
        }

        private void dgvAddListEntities_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void columnAddedEvent(object sender, DataGridViewColumnEventArgs e)
        {

        }

        private void cellContentClickEvent(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cellBeginEditEvent(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void rowEnterEvent(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
                dataGridViewAddListEntities.Rows[1].ReadOnly = true;
            else
            {

            }
        }

        private void keyPressEvent(object sender, KeyPressEventArgs e)
        {

        }

        private void EditingControlShowingEvent(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridViewAddListEntities.CurrentCell.ColumnIndex == 0)
            {
                e.Control.KeyPress += eventHandler.characterOnly;
            }
            else
            {
                e.Control.KeyPress -= eventHandler.characterOnly;
            }

            if (dataGridViewAddListEntities.CurrentCell.ColumnIndex == 1)
            {
                e.Control.KeyPress += eventHandler.characterOrSpaceOnly;
            }
            else
            {
                e.Control.KeyPress -= eventHandler.characterOrSpaceOnly;
            }

            if (dataGridViewAddListEntities.CurrentCell.ColumnIndex == 2)
            {
                e.Control.KeyPress += eventHandler.characterOrSpaceOnly;
            }
            else
            {
                e.Control.KeyPress -= eventHandler.characterOrSpaceOnly;
            }

            if (dataGridViewAddListEntities.CurrentCell.ColumnIndex == 5)
            {
                e.Control.KeyPress += eventHandler.digitOrSpaceOnly;
            }
            else
            {
                e.Control.KeyPress -= eventHandler.digitOrSpaceOnly;
            }

            if (dataGridViewAddListEntities.CurrentCell.ColumnIndex == 5)
            {
                e.Control.KeyPress += eventHandler.digitOrSpaceOnly;
            }
            else
            {
                e.Control.KeyPress -= eventHandler.digitOrSpaceOnly;
            }
        }

        private void btAddEntities_Click(object sender, EventArgs e)
        {
            int numRow = dataGridViewAddListEntities.RowCount;
            int numCellPerRow = dataGridViewAddListEntities.ColumnCount;
            MessageBox.Show("NumRow: " + numRow + "Num Cell: " + numCellPerRow);
            EntityDTO entityDTO = new EntityDTOImpl();
            for (int i = 0; i < numRow - 1; i++)
            {
                Entity entity = new Entity();
                entity.entityNo = dataGridViewAddListEntities.Rows[i].Cells[0].Value.ToString();
                entity.firstname = dataGridViewAddListEntities.Rows[i].Cells[1].Value.ToString();
                entity.lastname = dataGridViewAddListEntities.Rows[i].Cells[2].Value.ToString();
                entity.gender = dataGridViewAddListEntities.Rows[i].Cells[3].Value.ToString() == "true" ? true : false;
                entity.birthday = DateTime.Now;
                entity.businessPhone = dataGridViewAddListEntities.Rows[i].Cells[5].Value.ToString();
                entity.email = dataGridViewAddListEntities.Rows[i].Cells[6].Value.ToString();

                int signal = entityDTO.addEntity(entitiesContainer, entity);
                if (signal == 1)
                {
                    MessageBox.Show("Thêm Nhân Viên Mới Thành Công");
                }
                else
                {
                    MessageBox.Show("Xảy Ra Lỗi Trong Quá Trình Thêm Mới Nhân Viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
