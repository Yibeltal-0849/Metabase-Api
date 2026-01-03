using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.StrategicInnitiative.StrategicInnitiativeDelete.StrategicInnitiativeDeleteCommand
{

    ///   @author  Shimels Alem Strategic_InnitiativeDelete stored procedure.

    public class StrategicInnitiativeDeleteCommand : IRequest<IList<Strategic_Innitiative_Innitiative_ID>>
    {
        public string Innitiative_ID { get; set; }
    }
		
		 
	}
 
 
