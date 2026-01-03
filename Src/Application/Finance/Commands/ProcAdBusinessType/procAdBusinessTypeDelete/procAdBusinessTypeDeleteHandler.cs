using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAdBusinessTypeDelete.procAdBusinessTypeDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_Business_TypeDelete stored procedure.
	 
	 
      public class procAdBusinessTypeDeleteHandler : IRequestHandler<procAdBusinessTypeDeleteCommand, IList<AdBusinessType_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAdBusinessTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AdBusinessType_Id>> Handle( procAdBusinessTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<AdBusinessType_Id> result = await _procedureAdabter
                .Execute<AdBusinessType_Id>("[FINA].proc_Ad_Business_TypeDelete", request);
           

            return result;
        }
    }
}
 
