using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccPayFrequencyType.GetproccPayFrequencyTypeLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccPayFrequencyType.GetproccPayFrequencyTypeByPrimaryKey
{
    public class GetproccPayFrequencyTypeQueryHandler : IRequestHandler<GetproccPayFrequencyTypeByPrimaryKey, GetproccPayFrequencyTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccPayFrequencyTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccPayFrequencyTypeLoadAllListVm> Handle(GetproccPayFrequencyTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CPayFrequencyType> proccPayFrequencyTypes = await _procedureAdabter
               .Execute<CPayFrequencyType>("[FINA].[proc_c_PayFrequencyTypeLoadByPrimaryKey]", request);
            GetproccPayFrequencyTypeLoadAllListVm vm = new GetproccPayFrequencyTypeLoadAllListVm
            {
                proccPayFrequencyTypes = _mapper.Map<IList<CPayFrequencyType>, IList<GetproccPayFrequencyTypeLoadAllVm>>(proccPayFrequencyTypes)
            };

            return vm;
        }
    }
}
