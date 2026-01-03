using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAdBusinessTypeInsert.procAdBusinessTypeInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_Business_TypeInsert stored procedure.
	 
	 
      public class procAdBusinessTypeInsertHandler : IRequestHandler<procAdBusinessTypeInsertCommand, IList<AdBusinessType_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAdBusinessTypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AdBusinessType_Id>> Handle( procAdBusinessTypeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<AdBusinessType_Id> result = await _procedureAdabter
                .Execute<AdBusinessType_Id>("[FINA].proc_Ad_Business_TypeInsert", request);
           

            return result;
        }
    }
}
 
