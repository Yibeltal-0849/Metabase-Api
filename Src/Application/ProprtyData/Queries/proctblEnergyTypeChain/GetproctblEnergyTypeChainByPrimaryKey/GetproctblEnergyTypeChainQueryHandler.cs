using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblEnergyTypeChain.GetproctblEnergyTypeChainLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblEnergyTypeChain.GetproctblEnergyTypeChainByPrimaryKey
{
    public class GetproctblEnergyTypeChainQueryHandler : IRequestHandler<GetproctblEnergyTypeChainByPrimaryKey, GetproctblEnergyTypeChainLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblEnergyTypeChainQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblEnergyTypeChainLoadAllListVm> Handle(GetproctblEnergyTypeChainByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblEnergyTypeChain> proctblEnergyTypeChains = await _procedureAdabter
               .Execute<tblEnergyTypeChain>("[ProprtyData].[proc_tblEnergy_Type_ChainLoadByPrimaryKey]", request);
            GetproctblEnergyTypeChainLoadAllListVm vm = new GetproctblEnergyTypeChainLoadAllListVm
            {
                proctblEnergyTypeChains = _mapper.Map<IList<tblEnergyTypeChain>, IList<GetproctblEnergyTypeChainLoadAllVm>>(proctblEnergyTypeChains)
            };

            return vm;
        }
    }
}
