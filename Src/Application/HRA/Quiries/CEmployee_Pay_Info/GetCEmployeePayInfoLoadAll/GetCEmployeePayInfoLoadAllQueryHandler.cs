  
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.CEmployee_Pay_Info.GetCEmployeePayInfoLoadAll
{
    class GetCEmployeePayInfoLoadAllQueryHandler : IRequestHandler<GetCEmployeePayInfoLoadAllQuery, GetCEmployeePayInfoLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetCEmployeePayInfoLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCEmployeePayInfoLoadAllListVm> Handle(GetCEmployeePayInfoLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Proc_c_EmployeePayInfo> employeePayInfo = await _procedureAdabter
               .Execute<Proc_c_EmployeePayInfo>("[HRA].[proc_c_EmployeePayInfoLoadAll]");
            GetCEmployeePayInfoLoadAllListVm vm = new GetCEmployeePayInfoLoadAllListVm
            {
                EmployeePayInfos = _mapper.Map<IList<Proc_c_EmployeePayInfo>, IList<GetCEmployeePayInfoLoadAllVm>>(employeePayInfo)
            };

            return vm;
        }
    }
}
