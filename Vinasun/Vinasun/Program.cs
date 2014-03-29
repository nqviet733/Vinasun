﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vinasun.Model;
using Vinasun.EntityClass;

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
            TaxiModel tm = new TaxiModelImpl();
            UserRoleModel urm = new UserRoleModelImpl();
            var con = new EntityDiagramContainer();

            //====Group
            //Group g = new Group();
            //g.name = "new group";
            //g.address = "hcmc";
            //gm.addGroup(con, g);
            //g.address = "Ha Noi";
            //gm.updateGroup(con, g);
            //var group = gm.retrieveGroup(con, g.id);
            //Console.WriteLine("Name: " + group.name);
            //Console.WriteLine("Group: " + group.address);
            //var gr = gm.retrieveAllGroups(con);
            //var group1 = gm.retrieveGroup(con, 19);
            //gm.deleteGroup(con, group1);

            //====Entity
            //Entity en = new Entity();
            //en.firstname = "Viet";
            //en.lastname = "Nguyen";
            //en.birthday = new DateTime(1991, 9, 23);
            //en.businessPhone = "01666 754 539";
            //en.gender = true;
            //en.email = "nqviet733@gmail.com";
            //en.dateJoin = new DateTime(2013,9,16);
            //em.addEntity(con, en);
            //var entity = em.retrieveEntity(con, 1);
            //var entities = em.retrieveAllEntities(con);
            //entity.firstname = "Nam";
            //em.updateEntity(con, entity);
            //em.deleteEntity(con, em.retrieveEntity(con, 2));

            //====Taxi
            //Taxi t = new Taxi();
            //t.taxiNo = "53N - 012 567";
            //t.dateJoin = new DateTime(2013, 9, 16);
            //t.model = "M2014";
            //tm.addTaxi(con, t);
            //var taxi = tm.retrieveTaxi(con, 1);
            //var taxis = tm.retrieveAllTaxis(con);
            //t.model = "M2015";
            //tm.updateTaxi(con, taxi);
            //tm.deleteTaxi(con, taxi);


            //====User Role
            //UserRole ur = new UserRole();

            //ur.description = "Admin";
            //ur.permission = "Add new user, change configure";
            //ur.description = "Other";
            //ur.permission = "Other";
            //urm.addUserRole(con, ur);
            //var userRole = urm.retrieveUserRole(con, 4);
            //var userRoles = urm.retrieveAllUserRoles(con);
            //userRole.description = "Leader";
            //userRole.permission = "Add new checker, view group info, summary report";
            //urm.updateUserRole(con, userRole);
            //tm.updateTaxi(con, taxi);
            //urm.deleteUserRole(con, userRole);

        }
    }
}