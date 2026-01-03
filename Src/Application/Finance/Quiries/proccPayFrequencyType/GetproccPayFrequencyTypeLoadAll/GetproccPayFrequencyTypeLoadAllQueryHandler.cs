using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccPayFrequencyType.GetproccPayFrequencyTypeLoadAll
{
    class GetproccPayFrequencyTypeLoadAllQueryHandler : IRequestHandler<GetproccPayFrequencyTypeLoadAllQuery, GetproccPayFrequencyTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccPayFrequencyTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccPayFrequencyTypeLoadAllListVm> Handle(GetproccPayFrequencyTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CPayFrequencyType> proccPayFrequencyTypes = await _procedureAdabter
               .Execute<CPayFrequencyType>("[FINA].[proc_c_PayFrequencyTypeLoadAll]");
            GetproccPayFrequencyTypeLoadAllListVm vm = new GetproccPayFrequencyTypeLoadAllListVm
            {
                proccPayFrequencyTypes = _mapper.Map<IList<CPayFrequencyType>, IList<GetproccPayFrequencyTypeLoadAllVm>>(proccPayFrequencyTypes)
            };

            return vm;
        }
    }
}
