 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.procVATBusPostingGroup.GetprocVATBusPostingGroupLoadAll;

namespace Application.Finance.Quiries.procVATBusPostingGroup.GetVATBusPostingGroupLoadByPrimaryKey
{ 
	 
	#region procVATBusPostingGroupLoadByPrimaryKey  
      public class GetprocVATBusPostingGroupLoadByPrimaryKey: IRequest<GetprocVATBusPostingGroupLoadAllListVM>
    {
        public string Code { get; set; }
    }

    #endregion


}

