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

namespace XOKA.Application.HRA.Quiries.Employee_Doucment.GetProc_EmployeeDoucmentByPrimaryKey
{
    public class GetProc_EmployeeDoucmentByPrimaryQueryHandler : IRequestHandler<GetProc_EmployeeDoucmentByPrimaryKey, GetEmployeeDoucmentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetProc_EmployeeDoucmentByPrimaryQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter; 
        }

        public async Task<GetEmployeeDoucmentLoadAllListVm> Handle(GetProc_EmployeeDoucmentByPrimaryKey request, CancellationToken cancellationToken)
        {
            Guid ID = request.ID;
            IList<EmployeeDoucment> Employee_Doc = await _procedureAdabter
               .Execute<EmployeeDoucment>("[HRA].[proc_Emplyee_DocumentsLoadByPrimaryKey]", (nameof(ID), ID));
            GetEmployeeDoucmentLoadAllListVm vm = new GetEmployeeDoucmentLoadAllListVm
            {
                Employee_Doc = _mapper.Map<IList<EmployeeDoucment>, IList<GetEmployeeDoucmentLoadAllVm>>(Employee_Doc)
            };

            return vm;
        }
    }
}
