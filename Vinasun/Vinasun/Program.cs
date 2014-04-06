using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vinasun.Model;
using Vinasun.EntityClass;
using Vinasun.View;

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
            Application.Run(new Main());

            //GroupDTO gm = new GroupDTOImpl();
            //EntityDTO em = new EntityDTOImpl();
            //TaxiDTO tm = new TaxiDTOImpl();
            //UserRoleDTO urm = new UserRoleDTOImpl();
            //TaxiTypeDTO ttm = new TaxiTypeDTOImpl();
            //PriceRangeDTO prm = new PriceRangeDTOImpl();
            //DriverPercentangeDTO dpm = new DriverPercentangeDTOImpl();
            //CollectionDTO cm = new CollectionDTOImpl();
            //DayIncomeDTO dim = new DayIncomeDTOImpl();
            //ReasonNoIncomeDTO rnim = new ReasonNoIncomeDTOImpl();
            //RepairCostDTO rcm = new RepairCostDTOImpl();
            //SummaryNumberDTO snm = new SummaryNumberDTOImpl();
            //ProvineIncomeDTO pim = new ProvineIncomeDTOImpl();
            //TripCheckDTO tcm = new TripCheckDTOImpl();
            //SubtractionIncomeDTO sim = new SubtractionIncomeDTOImpl();
            //var con = new EntityDiagramContainer();

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


            //====Taxi Type
            //TaxiType tt = new TaxiType();
            //tt.symbol = "G";
            //tt.description = "Xe G";
            
            //ttm.addTaxiType(con, tt);
            //var taxiType = ttm.retrieveTaxiType(con, 3);
            //var taxiTypes = ttm.retrieveAllTaxiTypes(con);
            //taxiType.description = "Xe G Cho";
            //ttm.updateTaxiType(con, taxiType);
            //ttm.deleteTaxiType(con, taxiType);


            //====Price Range
            //PriceRange pr = new PriceRange();
            //pr.start = 400;
            //pr.end = 999;

            //prm.addPriceRange(con, pr);
            //var priceRange = prm.retrievePriceRange(con, 1);
            //var priceRanges = prm.retrieveAllPriceRanges(con);
            //priceRange.start = 500;
            //prm.updatePriceRange(con, priceRange);
            //prm.deletePriceRange(con, priceRange);
            //ttm.deleteTaxiType(con, taxiType);


            //====DriverPercentange
            //DriverPercentange dp = new DriverPercentange();
            //dp.percent = 20;
            //dpm.addDriverPercentange(con, dp);
            //var driverPercentange = dpm.retrieveDriverPercentange(con, 1);
            //var driverPercentanges = dpm.retrieveAllDriverPercentanges(con);
            //driverPercentange.percent = 30;
            //dpm.updateDriverPercentange(con, driverPercentange);
            //dpm.deleteDriverPercentange(con, driverPercentange);
            //prm.addPriceRange(con, pr);
            //var priceRange = prm.retrievePriceRange(con, 1);
            //var priceRanges = prm.retrieveAllPriceRanges(con);
            //priceRange.start = 500;
            //prm.updatePriceRange(con, priceRange);
            //prm.deletePriceRange(con, priceRange);
            //ttm.deleteTaxiType(con, taxiType);



            //====Collections
            //Collection c = new Collection();
            //c.taxiType = "7";
            //c.moneySum = 1000;
            //c.driver = "Trong Nhan";
            //c.kmSum = 100;
            //c.tripSum = 10;
            //c.created = new DateTime(2013, 09, 23);
            //cm.addCollection(con, c);

            //var collection = cm.retrieveCollection(con, 1);
            //var collections = cm.retrieveAllCollections(con);
            //collection.kmSum = 50;
            //cm.updateCollection(con, collection);
            //cm.deleteCollection(con, collection);

            //====DayIncome
            //DayIncome di = new DayIncome();
            //di.created = new DateTime(2009, 09, 23);
            //di.moneySum = 100;
            //di.driverIncome = 70;
            //di.companyIncome = 30;
            //di.rateIncome = 50;
            ////dim.addDayIncome(con, di);
            //var dayIncome = dim.retrieveDayIncome(con, 1);
            //var dayIncomes = dim.retrieveAllDayIncomes(con);
            //dayIncome.moneySum = 150;
            //dim.updateDayIncome(con, dayIncome);
            //dim.deleteDayIncome(con, dayIncome);

            //====DayIncome
            //ReasonNoIncome rni = new ReasonNoIncome();
            //rni.created = new DateTime(2003, 09, 23);
            //rni.status = "Nam Kho";
            ////rnim.addReasonNoIncome(con, rni);
            //var reasonNoIncome = rnim.retrieveReasonNoIncome(con, 1);
            //var reasonNoIncomes = rnim.retrieveAllReasonNoIncomes(con);
            //reasonNoIncome.status = "Sua Chua";
            //rnim.updateReasonNoIncome(con, reasonNoIncome);
            //rnim.deleteReasonNoIncome(con, reasonNoIncome);

            //====RepairCost
            //RepairCost rc = new RepairCost();
            //rc.created = new DateTime(2003, 09, 23);
            //rc.dateIn = new DateTime(2003, 09, 25);
            //rc.dateOut = new DateTime(2003, 10, 25);
            //int s = rcm.addRepairCost(con, rc);
            //var repairCost = rcm.retrieveRepairCost(con, 10);
            //var repairCosts = rcm.retrieveAllRepairCosts(con);
            //var i = repairCosts.Count();
            //repairCost.created = DateTime.Now;
            //var ii = rcm.updateRepairCost(con, repairCost);
            //var iii = rcm.deleteRepairCost(con, repairCost);


            //====Summary Number
            //SummaryNumber sn = new SummaryNumber();
            //sn.created = DateTime.Now;
            //sn.total = 100;
            //sn.kmSum = 200;
            //sn.tripSum = 20;
            //int s = snm.addSummaryNumber(con,sn);
            //var summaryNumber = snm.retrieveSummaryNumber(con, 1);
            //var summaryNumbers = snm.retrieveAllSummaryNumbers(con);
            //summaryNumber.total = 300;
            //var ii = snm.updateSummaryNumber(con, summaryNumber);
            //var iii = snm.deleteSummaryNumber(con, summaryNumber);


            //====Provine Income
            //ProvineIncome pi = new ProvineIncome();
            //pi.created = DateTime.Now;
            //pi.tripIncome = 100;
            //pi.overIncome = 200;
            //pi.priceIncome = 20;
            ////int s = pim.addProvineIncome(con, pi);
            //var provineIncome = pim.retrieveProvineIncome(con, 1);
            //var provineIncomes = pim.retrieveAllProvineIncomes(con);
            //provineIncome.tripIncome = 300;
            //var ii = pim.updateProvineIncome(con, provineIncome);
            //var iii = pim.deleteProvineIncome(con, provineIncome);

            //====Trip Check
            //TripCheck tc = new TripCheck();
            //tc.created = DateTime.Now;
            //tc.dateGo = DateTime.Now;
            //tc.dateBack = DateTime.Now;
            //int s = tcm.addTripCheck(con, tc);
            //var tripCheck = tcm.retrieveTripCheck(con, 1);
            //var tripChecks = tcm.retrieveAllTripChecks(con);
            //tripCheck.created = DateTime.Now.AddDays(1);
            //var ii = tcm.updateTripCheck(con, tripCheck);
            //var iii = tcm.deleteTripCheck(con, tripCheck);

            //====Subtraction Income
            //SubtractionIncome si = new SubtractionIncome();
            //si.created = DateTime.Now;
            //si.reason = "Repair";
            //int s = sim.addSubtractionIncome(con, si);
            //var subIncome = sim.retrieveSubtractionIncome(con, 1);
            //var tripChecks = sim.retrieveAllSubtractionIncomes(con);
            //subIncome.created = DateTime.Now.AddDays(1);
            //var ii = sim.updateSubtractionIncome(con, subIncome);
            //var iii = sim.deleteSubtractionIncome(con, subIncome);
            
        }
    }
}