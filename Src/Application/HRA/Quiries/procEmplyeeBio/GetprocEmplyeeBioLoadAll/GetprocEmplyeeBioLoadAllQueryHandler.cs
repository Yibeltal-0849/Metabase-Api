using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procEmplyeeBio.GetprocEmplyeeBioLoadAll
{
    class GetprocEmplyeeBioLoadAllQueryHandler : IRequestHandler<GetprocEmplyeeBioLoadAllQuery, GetprocEmplyeeBioLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocEmplyeeBioLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEmplyeeBioLoadAllListVm> Handle(GetprocEmplyeeBioLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<EmplyeeBio> procEmplyeeBios = await _procedureAdabter
               .Execute<EmplyeeBio>("[HRA].[proc_Emplyee_BioLoadAll]");
            GetprocEmplyeeBioLoadAllListVm vm = new GetprocEmplyeeBioLoadAllListVm
            {
                procEmplyeeBios = _mapper.Map<IList<EmplyeeBio>, IList<GetprocEmplyeeBioLoadAllVm>>(procEmplyeeBios)
            };

            return vm;
        }
    }
}
