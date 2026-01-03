using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblWoredas.GetproctblWoredasLoadAll
{
    class GetproctblWoredasLoadAllQueryHandler : IRequestHandler<GetproctblWoredasLoadAllQuery, GetproctblWoredasLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblWoredasLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblWoredasLoadAllListVm> Handle(GetproctblWoredasLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblWoredas> proctblWoredass = await _procedureAdabter
               .Execute<tblWoredas>("[ProprtyData].[proc_tblWoredasLoadAll]");
            GetproctblWoredasLoadAllListVm vm = new GetproctblWoredasLoadAllListVm
            {
                proctblWoredass = _mapper.Map<IList<tblWoredas>, IList<GetproctblWoredasLoadAllVm>>(proctblWoredass)
            };

            return vm;
        }
    }
}
