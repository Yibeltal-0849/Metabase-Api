using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblEnergyTypeChain.GetproctblEnergyTypeChainLoadAll
{
    class GetproctblEnergyTypeChainLoadAllQueryHandler : IRequestHandler<GetproctblEnergyTypeChainLoadAllQuery, GetproctblEnergyTypeChainLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblEnergyTypeChainLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblEnergyTypeChainLoadAllListVm> Handle(GetproctblEnergyTypeChainLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblEnergyTypeChain> proctblEnergyTypeChains = await _procedureAdabter
               .Execute<tblEnergyTypeChain>("[ProprtyData].[proc_tblEnergy_Type_ChainLoadAll]");
            GetproctblEnergyTypeChainLoadAllListVm vm = new GetproctblEnergyTypeChainLoadAllListVm
            {
                proctblEnergyTypeChains = _mapper.Map<IList<tblEnergyTypeChain>, IList<GetproctblEnergyTypeChainLoadAllVm>>(proctblEnergyTypeChains)
            };

            return vm;
        }
    }
}
