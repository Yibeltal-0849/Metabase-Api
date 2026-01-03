using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.HRA.Quiries.CEmployee_Pay_Info.GetCEmployeePayInfoLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.CEmployee_Pay_Info.GetCEmployeePayInfoByPrimaryKey
{
    public class GetCEmployeePayInfoQueryHandler : IRequestHandler<GetCEmployeePayInfoByPrimaryKey, GetCEmployeePayInfoLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetCEmployeePayInfoQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCEmployeePayInfoLoadAllListVm> Handle(GetCEmployeePayInfoByPrimaryKey request, CancellationToken cancellationToken)
        {
            long Id = request.Id;
            IList<Proc_c_EmployeePayInfo> EmployeePayInfos = await _procedureAdabter
               .Execute<Proc_c_EmployeePayInfo>("[HRA].[proc_C_EmployeePayInfoLoadByPrimaryKey]", (nameof(Id), Id));
            GetCEmployeePayInfoLoadAllListVm vm = new GetCEmployeePayInfoLoadAllListVm
            {
                EmployeePayInfos = _mapper.Map<IList<Proc_c_EmployeePayInfo>, IList<GetCEmployeePayInfoLoadAllVm>>(EmployeePayInfos)
            };

            return vm;
        }
    }
}
