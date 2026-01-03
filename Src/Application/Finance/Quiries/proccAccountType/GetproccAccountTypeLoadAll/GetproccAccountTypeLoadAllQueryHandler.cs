using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccAccountType.GetproccAccountTypeLoadAll
{
    class GetproccAccountTypeLoadAllQueryHandler : IRequestHandler<GetproccAccountTypeLoadAllQuery, GetproccAccountTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccAccountTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccAccountTypeLoadAllListVm> Handle(GetproccAccountTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CAccountType> proccAccountTypes = await _procedureAdabter
               .Execute<CAccountType>("[FINA].[proc_c_Account_TypeLoadAll]");
            GetproccAccountTypeLoadAllListVm vm = new GetproccAccountTypeLoadAllListVm
            {
                proccAccountTypes = _mapper.Map<IList<CAccountType>, IList<GetproccAccountTypeLoadAllVm>>(proccAccountTypes)
            };

            return vm;
        }
    }
}
