using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.Perspectives.PerspectivesDelete.PerspectivesDeleteCommand
{

    ///   @author  Shimels Alem PerspectivesDelete stored procedure.

    public class PerspectivesDeleteCommand : IRequest<IList<_Perspectives_Perspective_ID>>
    {
        public string Perspective_ID { get; set; }
    }
		
		 
	}
 
 
