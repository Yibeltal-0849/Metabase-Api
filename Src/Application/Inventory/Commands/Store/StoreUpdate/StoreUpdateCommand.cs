using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.Store.StoreUpdate.StoreUpdateCommand
{

    /// @author  Shimels Alem  StoreUpdate stored procedure.


    public class StoreUpdateCommand : IRequest<IList<_Store_Store_code>>
   {
        public string Store_code { get; set; }
        public string Store_Name { get; set; }
        public System.Guid? Store_Type { get; set; }
        public System.Guid? Organization { get; set; }
        public System.Guid? DIV { get; set; }
        public string Location { get; set; }
        public string Log { get; set; }
        public bool? Active { get; set; }
    }
		
		
		 
	}

