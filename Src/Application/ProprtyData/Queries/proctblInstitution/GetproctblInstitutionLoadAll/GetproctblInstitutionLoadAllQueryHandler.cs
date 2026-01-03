using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblInstitution.GetproctblInstitutionLoadAll
{
    class GetproctblInstitutionLoadAllQueryHandler : IRequestHandler<GetproctblInstitutionLoadAllQuery, GetproctblInstitutionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblInstitutionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblInstitutionLoadAllListVm> Handle(GetproctblInstitutionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblInstitution> proctblInstitutions = await _procedureAdabter
               .Execute<tblInstitution>("[ProprtyData].[proc_tblInstitutionLoadAll]");
            GetproctblInstitutionLoadAllListVm vm = new GetproctblInstitutionLoadAllListVm
            {
                proctblInstitutions = _mapper.Map<IList<tblInstitution>, IList<GetproctblInstitutionLoadAllVm>>(proctblInstitutions)
            };

            return vm;
        }
    }
}
