using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAdBusinessTypeUpdate.procAdBusinessTypeUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_Business_TypeUpdate stored procedure.
	 
	 
      public class procAdBusinessTypeUpdateHandler : IRequestHandler<procAdBusinessTypeUpdateCommand, IList<AdBusinessType_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAdBusinessTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AdBusinessType_Id>> Handle( procAdBusinessTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<AdBusinessType_Id> result = await _procedureAdabter
                .Execute<AdBusinessType_Id>("[FINA].proc_Ad_Business_TypeUpdate", request);
           

            return result;
        }
    }
}
 
