using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblSector.GetproctblSectorLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblSector.GetproctblSectorByPrimaryKey
{
    public class GetproctblSectorQueryHandler : IRequestHandler<GetproctblSectorByPrimaryKey, GetproctblSectorLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblSectorQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblSectorLoadAllListVm> Handle(GetproctblSectorByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblSector> proctblSectors = await _procedureAdabter
               .Execute<tblSector>("[ProprtyData].[proc_tblSectorLoadByPrimaryKey]", request);
            GetproctblSectorLoadAllListVm vm = new GetproctblSectorLoadAllListVm
            {
                proctblSectors = _mapper.Map<IList<tblSector>, IList<GetproctblSectorLoadAllVm>>(proctblSectors)
            };

            return vm;
        }
    }
}
