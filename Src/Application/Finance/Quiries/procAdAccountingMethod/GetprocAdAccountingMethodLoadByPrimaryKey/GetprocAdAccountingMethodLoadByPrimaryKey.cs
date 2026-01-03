 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.procAdAccountingMethod.GetprocAdAccountingMethodLoadAll;

namespace Application.Finance.Quiries.procAdAccountingMethod.GetprocAdAccountingMethodLoadByPrimaryKey
{ 
	 
	#region procAdAccountingMethodLoadByPrimaryKey  
      public class GetprocAdAccountingMethodLoadByPrimaryKey : IRequest<GetprocAdAccountingMethodLoadAllListVM>
    {
        public long Id { get; set; }
    }


    #endregion





}

