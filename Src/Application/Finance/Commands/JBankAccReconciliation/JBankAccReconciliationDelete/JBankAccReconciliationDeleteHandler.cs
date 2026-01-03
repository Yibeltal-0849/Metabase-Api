











using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JBankAccReconciliation.JBankAccReconciliationDelete.JBankAccReconciliationDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_Bank_Acc_ReconciliationDelete stored procedure.
	 
	 
      public class JBankAccReconciliationDeleteHandler : IRequestHandler<JBankAccReconciliationDeleteCommand, IList<JBankAccReconciliation_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JBankAccReconciliationDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JBankAccReconciliation_Branch_ID>> Handle( JBankAccReconciliationDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<JBankAccReconciliation_Branch_ID> result = await _procedureAdabter
                .Execute<JBankAccReconciliation_Branch_ID>("[FINA].J_Bank_Acc_ReconciliationDelete", request);
           

            return result;
        }
    }
}
  