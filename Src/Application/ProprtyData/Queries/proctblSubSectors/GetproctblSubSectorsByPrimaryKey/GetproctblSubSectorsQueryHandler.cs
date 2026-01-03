using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblSubSectors.GetproctblSubSectorsLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblSubSectors.GetproctblSubSectorsByPrimaryKey
{
    public class GetproctblSubSectorsQueryHandler : IRequestHandler<GetproctblSubSectorsByPrimaryKey, GetproctblSubSectorsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblSubSectorsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblSubSectorsLoadAllListVm> Handle(GetproctblSubSectorsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblSubSectors> proctblSubSectorss = await _procedureAdabter
               .Execute<tblSubSectors>("[ProprtyData].[proc_tblSubSectorsLoadByPrimaryKey]", request);
            GetproctblSubSectorsLoadAllListVm vm = new GetproctblSubSectorsLoadAllListVm
            {
                proctblSubSectorss = _mapper.Map<IList<tblSubSectors>, IList<GetproctblSubSectorsLoadAllVm>>(proctblSubSectorss)
            };

            return vm;
        }
    }
}
