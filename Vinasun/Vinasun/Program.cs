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
            var con = new EntityDiagramContainer();

            group g = new group();
            g.name = "New Group";
            g.address = "HCMC";    
            gm.addGroup(con, g);

            g.address = "Ha Noi";
            gm.updateGroup(con,g);

            var group = gm.retrieveGroup(con, g.id);
            Console.WriteLine("Name: " + group.name);
            Console.WriteLine("Group: " + group.address);

            var gr = gm.retrieveAllGroup(con);

            var group1 = gm.retrieveGroup(con, 19);
            gm.deleteGroup(con, group1);

        }
    }
}
