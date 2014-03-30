using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinasun.EntityClass;

namespace Vinasun.Model
{
    interface SummaryNumberDTO
    {

        int addSummaryNumber(EntityDiagramContainer container, SummaryNumber summaryNumber);
        SummaryNumber retrieveSummaryNumber(EntityDiagramContainer container, int summaryNumberId);
        IList<SummaryNumber> retrieveAllSummaryNumbers(EntityDiagramContainer container);
        int updateSummaryNumber(EntityDiagramContainer container, SummaryNumber summaryNumber);
        int deleteSummaryNumber(EntityDiagramContainer container, SummaryNumber summaryNumber);

    }
}
