using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procRentCollectionRequestFromBankInsert.GetRentCollectionRequestFromBankLoadAll;

namespace Application.Finance.Quiries.procRentCollectionRequestFromBankInsert.GetprocAnnualStrategicGoalsDetailsByPrimaryKey
{
    /// @author  Shimels Alem  proc_Annual_Strategic_Goals_DetailsLoadByPrimaryKey stored procedure.

    public class GetRentCollectionRequestFromBankByPrimaryKey : IRequest<GetRentCollectionRequestFromBankLoadAllListVm>
    {
		public string Application_NO { get; set; }
		
	}
}
