using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblEnergyChain.GetproctblEnergyChainLoadAll
{
    class GetproctblEnergyChainLoadAllQueryHandler : IRequestHandler<GetproctblEnergyChainLoadAllQuery, GetproctblEnergyChainLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblEnergyChainLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblEnergyChainLoadAllListVm> Handle(GetproctblEnergyChainLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblEnergyChain> proctblEnergyChains = await _procedureAdabter
               .Execute<tblEnergyChain>("[ProprtyData].[proc_tblEnergyChainLoadAll]");
            GetproctblEnergyChainLoadAllListVm vm = new GetproctblEnergyChainLoadAllListVm
            {
                proctblEnergyChains = _mapper.Map<IList<tblEnergyChain>, IList<GetproctblEnergyChainLoadAllVm>>(proctblEnergyChains)
            };

            return vm;
        }
    }
}
