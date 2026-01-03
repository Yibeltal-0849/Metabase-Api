using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccEmployeePayInfo.GetproccEmployeePayInfoLoadAll
{
    class GetproccEmployeePayInfoLoadAllQueryHandler : IRequestHandler<GetproccEmployeePayInfoLoadAllQuery, GetproccEmployeePayInfoLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccEmployeePayInfoLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccEmployeePayInfoLoadAllListVm> Handle(GetproccEmployeePayInfoLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CEmployeePayInfo> proccEmployeePayInfos = await _procedureAdabter
               .Execute<CEmployeePayInfo>("[FINA].[proc_c_EmployeePayInfoLoadAll]");
            GetproccEmployeePayInfoLoadAllListVm vm = new GetproccEmployeePayInfoLoadAllListVm
            {
                proccEmployeePayInfos = _mapper.Map<IList<CEmployeePayInfo>, IList<GetproccEmployeePayInfoLoadAllVm>>(proccEmployeePayInfos)
            };

            return vm;
        }
    }
}
