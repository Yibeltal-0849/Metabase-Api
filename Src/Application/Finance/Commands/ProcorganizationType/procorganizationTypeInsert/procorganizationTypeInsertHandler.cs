using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procorganizationTypeInsert.procorganizationTypeInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_organization_TypeInsert stored procedure.
	 
	 
      public class procorganizationTypeInsertHandler : IRequestHandler<procorganizationTypeInsertCommand, IList<procorganizationType_organization_Type_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procorganizationTypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<procorganizationType_organization_Type_Code>> Handle( procorganizationTypeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<procorganizationType_organization_Type_Code> result = await _procedureAdabter
                .Execute<procorganizationType_organization_Type_Code>("[FINA].proc_organization_TypeInsert", request);
           

            return result;
        }
    }
}
 
