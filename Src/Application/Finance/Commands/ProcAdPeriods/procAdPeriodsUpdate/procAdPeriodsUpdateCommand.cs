using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAdPeriodsUpdate.procAdPeriodsUpdateCommand
{

    /// @author  Henok Solomon  proc_Ad_PeriodsUpdate stored procedure.

    #region proc_Ad_PeriodsUpdate  

    /// proc_Ad_PeriodsUpdate stored procedure.

    public class procAdPeriodsUpdateCommand : IRequest<IList<AdPeriods_StartDate>>
    {
        public string originalStartDate { get; set; } 
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string org_Id { get; set; }
        public string name { get; set; }
        public bool? date_Locked { get; set; }
        public bool? new_Fiscal_Year { get; set; }
        public bool? closed { get; set; }
        public string year { get; set; }
        public bool? inventory_Period_Closed { get; set; }
    }


    #endregion


}


