



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.procPayrollAddition.procPayrollAdditionInsert.procPayrollAdditionInsertCommand
{

    /// @author  Shimels Alem  proc_Payroll_AdditionInsert stored procedure.


    public class procPayrollAdditionInsertHandler : IRequestHandler<procPayrollAdditionInsertCommand, IList<PayrollAddition_Addion_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPayrollAdditionInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PayrollAddition_Addion_ID>> Handle( procPayrollAdditionInsertCommand request, CancellationToken cancellationToken)
        {

            IList<PayrollAddition_Addion_ID> result = await _procedureAdabter
                .Execute<PayrollAddition_Addion_ID>("[FINA].proc_Payroll_AdditionInsert", request);
           

            return result;
        }
    }
}
 