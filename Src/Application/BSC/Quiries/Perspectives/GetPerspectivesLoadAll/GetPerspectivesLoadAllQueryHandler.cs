using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Quiries.Perspectives.GetPerspectivesLoadAll
{
    class GetPerspectivesLoadAllQueryHandler : IRequestHandler<GetPerspectivesLoadAllQuery, GetPerspectivesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetPerspectivesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetPerspectivesLoadAllListVm> Handle(GetPerspectivesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<_Perspectives> Perspectivess = await _procedureAdabter
               .Execute<_Perspectives>("[BSC].[proc_PerspectivesLoadAll]");
            GetPerspectivesLoadAllListVm vm = new GetPerspectivesLoadAllListVm
            {
                Perspectivess = _mapper.Map<IList<_Perspectives>, IList<GetPerspectivesLoadAllVm>>(Perspectivess)
            };

            return vm;
        }
    }
}
