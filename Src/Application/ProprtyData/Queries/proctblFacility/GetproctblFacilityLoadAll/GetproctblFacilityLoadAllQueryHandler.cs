using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblFacility.GetproctblFacilityLoadAll
{
    class GetproctblFacilityLoadAllQueryHandler : IRequestHandler<GetproctblFacilityLoadAllQuery, GetproctblFacilityLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblFacilityLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblFacilityLoadAllListVm> Handle(GetproctblFacilityLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblFacility> proctblFacilitys = await _procedureAdabter
               .Execute<tblFacility>("[ProprtyData].[proc_tblFacilityLoadAll]");
            GetproctblFacilityLoadAllListVm vm = new GetproctblFacilityLoadAllListVm
            {
                proctblFacilitys = _mapper.Map<IList<tblFacility>, IList<GetproctblFacilityLoadAllVm>>(proctblFacilitys)
            };

            return vm;
        }
    }
}
