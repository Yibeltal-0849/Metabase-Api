using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Payroll_Addition_Type.UpdatePayroll_Addition_Type
{
    public class UpdatePayroll_Addition_TypeHandler : IRequestHandler<UpdatePayroll_Addition_TypeCommand, IList<PayrollAdditionType_Addition_Type_code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdatePayroll_Addition_TypeHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PayrollAdditionType_Addition_Type_code>> Handle(UpdatePayroll_Addition_TypeCommand request, CancellationToken cancellationToken)
        {

            IList<PayrollAdditionType_Addition_Type_code> result = await _procedureAdabter
                .Execute<PayrollAdditionType_Addition_Type_code>("[HRA].[Payroll_Addition_TypeUpdate]", request);

            return result;
        }
    }
}
