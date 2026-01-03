using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblEnergyChain.GetproctblEnergyChainLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblEnergyChain.GetproctblEnergyChainByPrimaryKey
{
    public class GetproctblEnergyChainQueryHandler : IRequestHandler<GetproctblEnergyChainByPrimaryKey, GetproctblEnergyChainLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblEnergyChainQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblEnergyChainLoadAllListVm> Handle(GetproctblEnergyChainByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblEnergyChain> proctblEnergyChains = await _procedureAdabter
               .Execute<tblEnergyChain>("[ProprtyData].[proc_tblEnergyChainLoadByPrimaryKey]", request);
            GetproctblEnergyChainLoadAllListVm vm = new GetproctblEnergyChainLoadAllListVm
            {
                proctblEnergyChains = _mapper.Map<IList<tblEnergyChain>, IList<GetproctblEnergyChainLoadAllVm>>(proctblEnergyChains)
            };

            return vm;
        }
    }
}
