using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.Perspectives.PerspectivesUpdate.PerspectivesUpdateCommand
{

    ///   @author  Shimels Alem PerspectivesUpdate stored procedure.

    public class PerspectivesUpdateCommand : IRequest<IList<_Perspectives_Perspective_ID>>
    {
        public string Perspective_ID { get; set; }
        public string Perspective_Name { get; set; }
        public bool? ISactive { get; set; }

    }
		
		 
	}
 
 
