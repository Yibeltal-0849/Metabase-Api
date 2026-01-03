using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Payroll_Addition_Type.CreatePayroll_Addition_Type
{
    public class CreatePayroll_Addition_TypeHandler : IRequestHandler<CreatePayroll_Addition_TypeCommand, IList<PayrollAdditionType_Addition_Type_code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreatePayroll_Addition_TypeHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PayrollAdditionType_Addition_Type_code>> Handle(CreatePayroll_Addition_TypeCommand request, CancellationToken cancellationToken)
        {

            IList<PayrollAdditionType_Addition_Type_code> result = await _procedureAdabter
                .Execute<PayrollAdditionType_Addition_Type_code>("[HRA].[Payroll_Addition_TypeInsert]", request);

            return result;
        }

    }
}
