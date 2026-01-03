using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblResourceFacility.GetproctblResourceFacilityLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceFacility.GetproctblResourceFacilityByPrimaryKey
{
    public class GetproctblResourceFacilityQueryHandler : IRequestHandler<GetproctblResourceFacilityByPrimaryKey, GetproctblResourceFacilityLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblResourceFacilityQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceFacilityLoadAllListVm> Handle(GetproctblResourceFacilityByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblResourceFacility> proctblResourceFacilitys = await _procedureAdabter
               .Execute<tblResourceFacility>("[ProprtyData].[proc_tblResource_FacilityLoadByPrimaryKey]", request);
            GetproctblResourceFacilityLoadAllListVm vm = new GetproctblResourceFacilityLoadAllListVm
            {
                proctblResourceFacilitys = _mapper.Map<IList<tblResourceFacility>, IList<GetproctblResourceFacilityLoadAllVm>>(proctblResourceFacilitys)
            };

            return vm;
        }
    }
}
