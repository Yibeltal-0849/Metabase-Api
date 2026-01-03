using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblSector.GetproctblSectorLoadAll
{
    class GetproctblSectorLoadAllQueryHandler : IRequestHandler<GetproctblSectorLoadAllQuery, GetproctblSectorLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblSectorLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblSectorLoadAllListVm> Handle(GetproctblSectorLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblSector> proctblSectors = await _procedureAdabter
               .Execute<tblSector>("[ProprtyData].[proc_tblSectorLoadAll]");
            GetproctblSectorLoadAllListVm vm = new GetproctblSectorLoadAllListVm
            {
                proctblSectors = _mapper.Map<IList<tblSector>, IList<GetproctblSectorLoadAllVm>>(proctblSectors)
            };

            return vm;
        }
    }
}
