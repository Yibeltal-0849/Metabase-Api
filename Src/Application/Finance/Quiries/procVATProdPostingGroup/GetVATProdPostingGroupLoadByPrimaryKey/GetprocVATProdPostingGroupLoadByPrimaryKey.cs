 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.procVATProdPostingGroup.GetprocVATProdPostingGroupLoadAll;

namespace Application.Finance.Quiries.procVATProdPostingGroup.GetVATProdPostingGroupLoadByPrimaryKey
{ 
	 
	#region procVATProdPostingGroupLoadByPrimaryKey  
      public class GetprocVATProdPostingGroupLoadByPrimaryKey : IRequest<GetprocVATProdPostingGroupLoadAllListVM>
    {

        public string Code { get; set; }
    }






    #endregion

}

