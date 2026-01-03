using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.C_Employee.GetC_EmployeeLoadAll
{
    class GetC_EmployeeLoadAllQueryHandler : IRequestHandler<GetC_EmployeeLoadAllQuery, GetC_EmployeeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetC_EmployeeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetC_EmployeeLoadAllListVm> Handle(GetC_EmployeeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CEmployee> C_Employees = await _procedureAdabter
               .Execute<CEmployee>("[HRA].[proc_C_EmployeeLoadAll]");
            GetC_EmployeeLoadAllListVm vm = new GetC_EmployeeLoadAllListVm
            {
                C_Employees = _mapper.Map<IList<CEmployee>, IList<GetC_EmployeeLoadAllVm>>(C_Employees)
            };

            return vm;
        }
    }
}
