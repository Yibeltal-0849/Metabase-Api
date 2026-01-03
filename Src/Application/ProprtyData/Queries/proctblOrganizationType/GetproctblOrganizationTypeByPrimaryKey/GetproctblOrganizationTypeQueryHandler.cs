using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblOrganizationType.GetproctblOrganizationTypeLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblOrganizationType.GetproctblOrganizationTypeByPrimaryKey
{
    public class GetproctblOrganizationTypeQueryHandler : IRequestHandler<GetproctblOrganizationTypeByPrimaryKey, GetproctblOrganizationTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblOrganizationTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblOrganizationTypeLoadAllListVm> Handle(GetproctblOrganizationTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblOrganizationType> proctblOrganizationTypes = await _procedureAdabter
               .Execute<tblOrganizationType>("[ProprtyData].[proc_tblOrganization_TypeLoadByPrimaryKey]", request);
            GetproctblOrganizationTypeLoadAllListVm vm = new GetproctblOrganizationTypeLoadAllListVm
            {
                proctblOrganizationTypes = _mapper.Map<IList<tblOrganizationType>, IList<GetproctblOrganizationTypeLoadAllVm>>(proctblOrganizationTypes)
            };

            return vm;
        }
    }
}
