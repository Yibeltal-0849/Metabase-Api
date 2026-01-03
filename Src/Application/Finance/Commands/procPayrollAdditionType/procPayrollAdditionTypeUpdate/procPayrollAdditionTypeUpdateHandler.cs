

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.procPayrollAdditionType.procPayrollAdditionTypeUpdate.procPayrollAdditionTypeUpdateCommand
{

    /// @author  Shimels Alem  proc_Payroll_Addition_TypeUpdate stored procedure.


    public class procPayrollAdditionTypeUpdateHandler : IRequestHandler<procPayrollAdditionTypeUpdateCommand, IList<PayrollAdditionType_Addition_Type_code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPayrollAdditionTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PayrollAdditionType_Addition_Type_code>> Handle( procPayrollAdditionTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<PayrollAdditionType_Addition_Type_code> result = await _procedureAdabter
                .Execute<PayrollAdditionType_Addition_Type_code>("[FINA].proc_Payroll_Addition_TypeUpdate", request);
           

            return result;
        }
    }
}
 