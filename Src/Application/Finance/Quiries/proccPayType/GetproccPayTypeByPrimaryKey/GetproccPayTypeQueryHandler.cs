using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccPayType.GetproccPayTypeLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccPayType.GetproccPayTypeByPrimaryKey
{
    public class GetproccPayTypeQueryHandler : IRequestHandler<GetproccPayTypeByPrimaryKey, GetproccPayTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccPayTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccPayTypeLoadAllListVm> Handle(GetproccPayTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CPayType> proccPayTypes = await _procedureAdabter
               .Execute<CPayType>("[FINA].[proc_c_PayTypeLoadByPrimaryKey]", request);
            GetproccPayTypeLoadAllListVm vm = new GetproccPayTypeLoadAllListVm
            {
                proccPayTypes = _mapper.Map<IList<CPayType>, IList<GetproccPayTypeLoadAllVm>>(proccPayTypes)
            };

            return vm;
        }
    }
}
