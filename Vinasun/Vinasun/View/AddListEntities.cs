using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vinasun.View
{
    public partial class AddListEntities : Form
    {

        Vinasun.CommonClass.EventHandler eventHandler;

        public AddListEntities()
        {
            InitializeComponent();

            eventHandler = new Vinasun.CommonClass.EventHandler();
        }

        private void cellValidatingEvent(object sender, DataGridViewCellValidatingEventArgs e, KeyPressEventArgs k)
        {
            if ()
        }
    }
}
