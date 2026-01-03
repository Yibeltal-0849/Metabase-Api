using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.HRA.Quiries.Employee_Doucment.GetEmployeeDoucmentLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.Employee_Doucment.GetEmployeeDoucmentByPrimaryKey_employee_Id
{
    public class GetEmployeeDoucmentQueryHandler : IRequestHandler<GetEmployeeDoucmentByPrimaryKey_employee_Id, GetEmployeeDoucmentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetEmployeeDoucmentQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetEmployeeDoucmentLoadAllListVm> Handle(GetEmployeeDoucmentByPrimaryKey_employee_Id request, CancellationToken cancellationToken)
        {
            Guid Employee_Id = request.Employee_Id;
            IList<EmployeeDoucment> Employee_Doc = await _procedureAdabter
               .Execute<EmployeeDoucment>("[HRA].[proc_Emplyee_DocumentsLoadByPrimaryKey_Employee_Id]", (nameof(Employee_Id), Employee_Id));
            GetEmployeeDoucmentLoadAllListVm vm = new GetEmployeeDoucmentLoadAllListVm
            {
                Employee_Doc = _mapper.Map<IList<EmployeeDoucment>, IList<GetEmployeeDoucmentLoadAllVm>>(Employee_Doc)
            };

            return vm;
        }
    }
}
