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

namespace Vinasun.View
{
    public partial class AddListEntities : Form
    {

        Vinasun.CommonClass.EventHandler eventHandler;
        Validation validatior;

        public AddListEntities()
        {
            InitializeComponent();

            eventHandler = new Vinasun.CommonClass.EventHandler();
            validatior = new Validation();
            validatior.isNotEmptyForNewCell(dataGridViewAddListEntities, 0, 10);
        }

        private void cellValidatingEvent(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (validatior.isNotEmptyForCell(sender, e.RowIndex, e.ColumnIndex))
            //{

            //}
            
        }

        private void dataGridViewAddListEntities_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            //validatior.isNotEmptyForCell(sender, e.RowIndex, e.ColumnIndex);
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
            //validatior.isNotEmptyForNewCell(sender, e.RowIndex, 10);
        }

        private void columnAddedEvent(object sender, DataGridViewColumnEventArgs e)
        {
           
        }
    }
}
