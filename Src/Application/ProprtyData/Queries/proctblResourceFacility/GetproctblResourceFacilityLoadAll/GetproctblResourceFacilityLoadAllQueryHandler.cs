using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceFacility.GetproctblResourceFacilityLoadAll
{
    class GetproctblResourceFacilityLoadAllQueryHandler : IRequestHandler<GetproctblResourceFacilityLoadAllQuery, GetproctblResourceFacilityLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblResourceFacilityLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceFacilityLoadAllListVm> Handle(GetproctblResourceFacilityLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblResourceFacility> proctblResourceFacilitys = await _procedureAdabter
               .Execute<tblResourceFacility>("[ProprtyData].[proc_tblResource_FacilityLoadAll]");
            GetproctblResourceFacilityLoadAllListVm vm = new GetproctblResourceFacilityLoadAllListVm
            {
                proctblResourceFacilitys = _mapper.Map<IList<tblResourceFacility>, IList<GetproctblResourceFacilityLoadAllVm>>(proctblResourceFacilitys)
            };

            return vm;
        }
    }
}
