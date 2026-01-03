using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblFacilityType.GetproctblFacilityTypeLoadAll
{
    class GetproctblFacilityTypeLoadAllQueryHandler : IRequestHandler<GetproctblFacilityTypeLoadAllQuery, GetproctblFacilityTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblFacilityTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblFacilityTypeLoadAllListVm> Handle(GetproctblFacilityTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblFacility_Type> proctblFacilityTypes = await _procedureAdabter
               .Execute<tblFacility_Type>("[ProprtyData].[proc_tblFacility_TypeLoadAll]");
            GetproctblFacilityTypeLoadAllListVm vm = new GetproctblFacilityTypeLoadAllListVm
            {
                proctblFacilityTypes = _mapper.Map<IList<tblFacility_Type>, IList<GetproctblFacilityTypeLoadAllVm>>(proctblFacilityTypes)
            };

            return vm;
        }
    }
}
