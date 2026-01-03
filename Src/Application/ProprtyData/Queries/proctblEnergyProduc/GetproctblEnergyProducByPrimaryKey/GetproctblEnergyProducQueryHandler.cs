using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblEnergyProduc.GetproctblEnergyProducLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblEnergyProduc.GetproctblEnergyProducByPrimaryKey
{
    public class GetproctblEnergyProducQueryHandler : IRequestHandler<GetproctblEnergyProducByPrimaryKey, GetproctblEnergyProducLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblEnergyProducQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblEnergyProducLoadAllListVm> Handle(GetproctblEnergyProducByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblEnergyProduc> proctblEnergyProducs = await _procedureAdabter
               .Execute<tblEnergyProduc>("[ProprtyData].[proc_tblEnergyProducLoadByPrimaryKey]", request);
            GetproctblEnergyProducLoadAllListVm vm = new GetproctblEnergyProducLoadAllListVm
            {
                proctblEnergyProducs = _mapper.Map<IList<tblEnergyProduc>, IList<GetproctblEnergyProducLoadAllVm>>(proctblEnergyProducs)
            };

            return vm;
        }
    }
}
