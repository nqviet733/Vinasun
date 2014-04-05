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

    }
}
