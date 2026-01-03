 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.procAccountPropose.GetprocAccountProposeLoadAll;

namespace Application.Finance.Quiries.procAccountPropose.GetprocAccountProposeLoadByPrimaryKey
{ 
	 
	#region procAccountProposeLoadByPrimaryKey  
      public class GetprocAccountProposeLoadByPrimaryKey : IRequest<GetprocAccountProposeLoadAllListVM>
    {
        public string Name { get; set; }
    }

    #endregion


}

