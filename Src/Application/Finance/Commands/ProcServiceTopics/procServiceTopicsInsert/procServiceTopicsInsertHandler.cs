using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procServiceTopicsInsert.procServiceTopicsInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_Service_TopicsInsert stored procedure.
	 
	 
      public class procServiceTopicsInsertHandler : IRequestHandler<procServiceTopicsInsertCommand, IList<Service_Topics>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procServiceTopicsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Service_Topics>> Handle( procServiceTopicsInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Service_Topics> result = await _procedureAdabter
                .Execute<Service_Topics>("[FINA].proc_Service_TopicsInsert", request);
           

            return result;
        }
    }
}
 
