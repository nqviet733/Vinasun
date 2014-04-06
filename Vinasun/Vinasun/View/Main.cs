using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vinasun.Model;
using Vinasun.EntityClass;

namespace Vinasun.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            var entitiesContainer = new EntityDiagramContainer();
            CollectionDTO colectionDTO = new CollectionDTOImpl();
            IList<Collection> collections = colectionDTO.retrieveAllCollections(entitiesContainer);
            collectionDataGridView.DataSource = collections;
            
        }

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && textBoxX1.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void errorProvider1_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX1_Validating(object sender, CancelEventArgs e)
        {
            validate();
        }
        private bool validate()
        {
            bool status = true;
            if (this.textBoxX1.Text.Length > 5)
            {
                errorProvider1.SetError(this.textBoxX1, "Please Provide....");
                this.buttonX1.Focus();
                status = false;
            }
            else
            {
                errorProvider1.SetError(this.textBoxX1, "Please Provide....");
            }
            return status;
        }

    }
}
