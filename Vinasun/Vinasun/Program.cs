using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vinasun.Model;

namespace Vinasun
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            GroupModel gm = new GroupModelImpl();

            leader l = new leader();
            l.username = "abs";
            l.password = "123";

            group g = new group();
            g.name = "New Group";
            g.address = "HCMC";
            g.leader = l;

                
            var con = new EntityDiagramContainer();
            gm.addGroup(con,g);
        }
    }
}
