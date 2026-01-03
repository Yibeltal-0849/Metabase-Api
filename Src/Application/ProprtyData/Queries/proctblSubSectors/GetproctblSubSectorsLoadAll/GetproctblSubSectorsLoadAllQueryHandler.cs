using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblSubSectors.GetproctblSubSectorsLoadAll
{
    class GetproctblSubSectorsLoadAllQueryHandler : IRequestHandler<GetproctblSubSectorsLoadAllQuery, GetproctblSubSectorsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblSubSectorsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblSubSectorsLoadAllListVm> Handle(GetproctblSubSectorsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblSubSectors> proctblSubSectorss = await _procedureAdabter
               .Execute<tblSubSectors>("[ProprtyData].[proc_tblSubSectorsLoadAll]");
            GetproctblSubSectorsLoadAllListVm vm = new GetproctblSubSectorsLoadAllListVm
            {
                proctblSubSectorss = _mapper.Map<IList<tblSubSectors>, IList<GetproctblSubSectorsLoadAllVm>>(proctblSubSectorss)
            };

            return vm;
        }
    }
}
