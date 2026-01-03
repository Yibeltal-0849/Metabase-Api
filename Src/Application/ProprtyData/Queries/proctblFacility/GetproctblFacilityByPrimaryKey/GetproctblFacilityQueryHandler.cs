using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblFacility.GetproctblFacilityLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblFacility.GetproctblFacilityByPrimaryKey
{
    public class GetproctblFacilityQueryHandler : IRequestHandler<GetproctblFacilityByPrimaryKey, GetproctblFacilityLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblFacilityQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblFacilityLoadAllListVm> Handle(GetproctblFacilityByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblFacility> proctblFacilitys = await _procedureAdabter
               .Execute<tblFacility>("[ProprtyData].[proc_tblFacilityLoadByPrimaryKey]", request);
            GetproctblFacilityLoadAllListVm vm = new GetproctblFacilityLoadAllListVm
            {
                proctblFacilitys = _mapper.Map<IList<tblFacility>, IList<GetproctblFacilityLoadAllVm>>(proctblFacilitys)
            };

            return vm;
        }
    }
}
