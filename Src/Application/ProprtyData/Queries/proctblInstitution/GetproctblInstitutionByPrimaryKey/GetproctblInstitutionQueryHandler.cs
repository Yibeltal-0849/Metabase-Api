using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblInstitution.GetproctblInstitutionLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblInstitution.GetproctblInstitutionByPrimaryKey
{
    public class GetproctblInstitutionQueryHandler : IRequestHandler<GetproctblInstitutionByPrimaryKey, GetproctblInstitutionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblInstitutionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblInstitutionLoadAllListVm> Handle(GetproctblInstitutionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblInstitution> proctblInstitutions = await _procedureAdabter
               .Execute<tblInstitution>("[ProprtyData].[proc_tblInstitutionLoadByPrimaryKey]", request);
            GetproctblInstitutionLoadAllListVm vm = new GetproctblInstitutionLoadAllListVm
            {
                proctblInstitutions = _mapper.Map<IList<tblInstitution>, IList<GetproctblInstitutionLoadAllVm>>(proctblInstitutions)
            };

            return vm;
        }
    }
}
