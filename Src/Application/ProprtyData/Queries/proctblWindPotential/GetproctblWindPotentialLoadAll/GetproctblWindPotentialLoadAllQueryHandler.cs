using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblWindPotential.GetproctblWindPotentialLoadAll
{
    class GetproctblWindPotentialLoadAllQueryHandler : IRequestHandler<GetproctblWindPotentialLoadAllQuery, GetproctblWindPotentialLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblWindPotentialLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblWindPotentialLoadAllListVm> Handle(GetproctblWindPotentialLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblWindPotential> proctblWindPotentials = await _procedureAdabter
               .Execute<tblWindPotential>("[ProprtyData].[proc_tblWindPotentialLoadAll]");
            GetproctblWindPotentialLoadAllListVm vm = new GetproctblWindPotentialLoadAllListVm
            {
                proctblWindPotentials = _mapper.Map<IList<tblWindPotential>, IList<GetproctblWindPotentialLoadAllVm>>(proctblWindPotentials)
            };

            return vm;
        }
    }
}
