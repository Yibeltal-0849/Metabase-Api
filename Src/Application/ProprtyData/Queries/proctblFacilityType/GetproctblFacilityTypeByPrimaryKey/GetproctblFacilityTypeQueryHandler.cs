using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblFacilityType.GetproctblFacilityTypeLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblFacilityType.GetproctblFacilityTypeByPrimaryKey
{
    public class GetproctblFacilityTypeQueryHandler : IRequestHandler<GetproctblFacilityTypeByPrimaryKey, GetproctblFacilityTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblFacilityTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblFacilityTypeLoadAllListVm> Handle(GetproctblFacilityTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblFacility_Type> proctblFacilityTypes = await _procedureAdabter
               .Execute<tblFacility_Type>("[ProprtyData].[proc_tblFacility_TypeLoadByPrimaryKey]", request);
            GetproctblFacilityTypeLoadAllListVm vm = new GetproctblFacilityTypeLoadAllListVm
            {
                proctblFacilityTypes = _mapper.Map<IList<tblFacility_Type>, IList<GetproctblFacilityTypeLoadAllVm>>(proctblFacilityTypes)
            };

            return vm;
        }
    }
}
