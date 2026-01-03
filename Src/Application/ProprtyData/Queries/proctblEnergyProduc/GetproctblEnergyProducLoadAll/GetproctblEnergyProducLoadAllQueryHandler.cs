using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblEnergyProduc.GetproctblEnergyProducLoadAll
{
    class GetproctblEnergyProducLoadAllQueryHandler : IRequestHandler<GetproctblEnergyProducLoadAllQuery, GetproctblEnergyProducLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblEnergyProducLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblEnergyProducLoadAllListVm> Handle(GetproctblEnergyProducLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblEnergyProduc> proctblEnergyProducs = await _procedureAdabter
               .Execute<tblEnergyProduc>("[ProprtyData].[proc_tblEnergyProducLoadAll]");
            GetproctblEnergyProducLoadAllListVm vm = new GetproctblEnergyProducLoadAllListVm
            {
                proctblEnergyProducs = _mapper.Map<IList<tblEnergyProduc>, IList<GetproctblEnergyProducLoadAllVm>>(proctblEnergyProducs)
            };

            return vm;
        }
    }
}
