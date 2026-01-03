using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccAccountType.GetproccAccountTypeLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccAccountType.GetproccAccountTypeByPrimaryKey
{
    public class GetproccAccountTypeQueryHandler : IRequestHandler<GetproccAccountTypeByPrimaryKey, GetproccAccountTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccAccountTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccAccountTypeLoadAllListVm> Handle(GetproccAccountTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CAccountType> proccAccountTypes = await _procedureAdabter
               .Execute<CAccountType>("[FINA].[proc_c_Account_TypeLoadByPrimaryKey]", request);
            GetproccAccountTypeLoadAllListVm vm = new GetproccAccountTypeLoadAllListVm
            {
                proccAccountTypes = _mapper.Map<IList<CAccountType>, IList<GetproccAccountTypeLoadAllVm>>(proccAccountTypes)
            };

            return vm;
        }
    }
}
