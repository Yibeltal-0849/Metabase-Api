 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.proccGeneraljournal.GetproccGeneraljournalLoadAll;

namespace Application.Finance.Quiries.proccGeneraljournal.GetproccGeneraljournalLoadByPrimaryKey
{ 
	 
	#region proccGeneraljournalLoadByPrimaryKey  
      public class GetproccGeneraljournalLoadByPrimaryKey : IRequest<GetproccGeneraljournalLoadAllListVM>
    {
        public string account_Id { get; set; }
        public double brnach_ID { get; set; }
        public System.DateTime dateDoc { get; set; }
        public double org_ID { get; set; }

    }


    #endregion






}

