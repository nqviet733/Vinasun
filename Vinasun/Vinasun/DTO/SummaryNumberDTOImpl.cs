using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    class SummaryNumberDTOImpl : SummaryNumberDTO
    {

        //Create new SummaryNumber
        int SummaryNumberDTO.addSummaryNumber(EntityDiagramContainer container, SummaryNumber summaryNumber)
        {
            int signal = 0;
            try
            {
                container.SummaryNumbers.Add(summaryNumber);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to add new SummaryNumber. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //retrieve a SummaryNumber already exist
        SummaryNumber SummaryNumberDTO.retrieveSummaryNumber(EntityDiagramContainer container, int summaryNumberId)
        {
            SummaryNumber ur = null;
            try
            {
                ur = container.SummaryNumbers.Find(summaryNumberId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to retrieve a SummaryNumber. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return ur;
        }

        //retrieve all user roles
        IList<SummaryNumber> SummaryNumberDTO.retrieveAllSummaryNumbers(EntityDiagramContainer container)
        {
            IList<SummaryNumber> sns = null;
            try
            {
                sns = container.Set<SummaryNumber>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to get list SummaryNumber. Try again, and if the problem persists see your system administrator: " + ex);
            }
            finally
            {
                if (sns == null)
                {
                    sns = new List<SummaryNumber>();
                }
            }
            return sns;
        }

        //update a SummaryNumber already exist
        int SummaryNumberDTO.updateSummaryNumber(EntityDiagramContainer container, SummaryNumber summaryNumberIn)
        {
            int signal = 0;
            try
            {
                container.SummaryNumbers.FirstOrDefault(c => c.id == summaryNumberIn.id);
                signal = container.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to update already exist SummaryNumber. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

        //delete a SummaryNumber already exist
        int SummaryNumberDTO.deleteSummaryNumber(EntityDiagramContainer container, SummaryNumber summaryNumberIn)
        {
            int signal = 0;
            try
            {
                var sn = (from summaryNumber in container.SummaryNumbers
                          where summaryNumber.id == summaryNumberIn.id
                          select summaryNumber).FirstOrDefault();
                container.SummaryNumbers.Remove(sn);
                signal = container.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to delete already exist SummaryNumber. Try again, and if the problem persists see your system administrator: " + ex);
            }
            return signal;
        }

    }
}
