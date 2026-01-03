using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procPayrollAddition.procPayrollAdditionDelete.procPayrollAdditionDeleteCommand
{

    /// @author  Shimels Alem  proc_Payroll_AdditionDelete stored procedure.


    public class procPayrollAdditionDeleteHandler : IRequestHandler<procPayrollAdditionDeleteCommand, IList<PayrollAddition_Addion_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPayrollAdditionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PayrollAddition_Addion_ID>> Handle( procPayrollAdditionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<PayrollAddition_Addion_ID> result = await _procedureAdabter
                .Execute<PayrollAddition_Addion_ID>("[FINA].proc_Payroll_AdditionDelete", request);
           

            return result;
        }
    }
}
  