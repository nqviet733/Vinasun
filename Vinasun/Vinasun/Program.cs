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
            EntityModel em = new EntityModelImpl();
            var con = new EntityDiagramContainer();

            //Group g = new Group();
            //g.name = "new group";
            //g.address = "hcmc";
            //gm.addGroup(con, g);

            //g.address = "Ha Noi";
            //gm.updateGroup(con, g);

            //var group = gm.retrieveGroup(con, g.id);
            //Console.WriteLine("Name: " + group.name);
            //Console.WriteLine("Group: " + group.address);

            //var gr = gm.retrieveAllGroup(con);

            //var group1 = gm.retrieveGroup(con, 19);
            //gm.deleteGroup(con, group1);

            Entity en = new Entity();
            en.firstname = "Viet";
            en.lastname = "Nguyen";
            DateTime dt = new DateTime(1991,9,23);
            en.birthday = dt;
            en.businessPhone = "01666 754 539";
            en.gender = true;
            en.email = "nqviet733@gmail.com";

            em.addEntity(con, en);
        }
    }
}
