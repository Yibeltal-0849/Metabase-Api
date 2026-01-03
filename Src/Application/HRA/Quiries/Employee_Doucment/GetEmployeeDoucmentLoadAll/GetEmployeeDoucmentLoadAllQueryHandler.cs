using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.Employee_Doucment.GetEmployeeDoucmentLoadAll
{
    class GetEmployeeDoucmentLoadAllQueryHandler : IRequestHandler<GetEmployeeDoucmentLoadAllQuery, GetEmployeeDoucmentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetEmployeeDoucmentLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetEmployeeDoucmentLoadAllListVm> Handle(GetEmployeeDoucmentLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<EmployeeDoucment> Employee_Doc = await _procedureAdabter
               .Execute<EmployeeDoucment>("[HRA].[proc_Emplyee_DocumentsLoadAll]");
            GetEmployeeDoucmentLoadAllListVm vm = new GetEmployeeDoucmentLoadAllListVm
            {
                Employee_Doc = _mapper.Map<IList<EmployeeDoucment>, IList<GetEmployeeDoucmentLoadAllVm>>(Employee_Doc)
            };

            return vm;
        }
    }
}
