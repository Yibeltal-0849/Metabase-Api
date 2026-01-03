using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procPayrollAdditionType.procPayrollAdditionTypeDelete.procPayrollAdditionTypeDeleteCommand
{

    /// @author  Shimels Alem  proc_Payroll_Addition_TypeDelete stored procedure.


    public class procPayrollAdditionTypeDeleteHandler : IRequestHandler<procPayrollAdditionTypeDeleteCommand, IList<PayrollAdditionType_Addition_Type_code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPayrollAdditionTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PayrollAdditionType_Addition_Type_code>> Handle( procPayrollAdditionTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<PayrollAdditionType_Addition_Type_code> result = await _procedureAdabter
                .Execute<PayrollAdditionType_Addition_Type_code>("[FINA].proc_Payroll_Addition_TypeDelete", request);
           

            return result;
        }
    }
}
  