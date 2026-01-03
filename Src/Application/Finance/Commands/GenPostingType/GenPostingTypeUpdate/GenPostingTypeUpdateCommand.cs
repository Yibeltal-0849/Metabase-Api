using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.GenPostingType.GenPostingTypeUpdate.GenPostingTypeUpdateCommand
{

    /// @author  Shimels Alem  Gen_Posting_TypeUpdate stored procedure.


    public class GenPostingTypeUpdateCommand : IRequest<IList<GenPostingType_Code>>
    {
        public string Code { get; set; }
        public bool? Is_Active { get; set; }

    }
		
		
		 
}

