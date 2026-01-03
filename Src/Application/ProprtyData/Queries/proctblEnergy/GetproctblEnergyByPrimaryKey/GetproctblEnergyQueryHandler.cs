using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblEnergy.GetproctblEnergyLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblEnergy.GetproctblEnergyByPrimaryKey
{
    public class GetproctblEnergyQueryHandler : IRequestHandler<GetproctblEnergyByPrimaryKey, GetproctblEnergyLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblEnergyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblEnergyLoadAllListVm> Handle(GetproctblEnergyByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblEnergy> proctblEnergys = await _procedureAdabter
               .Execute<tblEnergy>("[ProprtyData].[proc_tblEnergyLoadByPrimaryKey]", request);
            GetproctblEnergyLoadAllListVm vm = new GetproctblEnergyLoadAllListVm
            {
                proctblEnergys = _mapper.Map<IList<tblEnergy>, IList<GetproctblEnergyLoadAllVm>>(proctblEnergys)
            };

            return vm;
        }
    }
}
