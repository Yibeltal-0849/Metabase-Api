using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.ProcProportyStaticData.GetprocProcProportyStaticDataLoadAll
{
    class GetprocProcProportyStaticDataLoadAllQueryHandler : IRequestHandler<GetprocProcProportyStaticDataLoadAllListQuery, GetprocProcProportyStaticDataLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocProcProportyStaticDataLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocProcProportyStaticDataLoadAllListVm> Handle(GetprocProcProportyStaticDataLoadAllListQuery request, CancellationToken cancellationToken)
        {
            IList<Proporty_Static_Data> ProcProportyStaticdata = await _procedureAdabter
               .Execute<Proporty_Static_Data>("[ProprtyData].[proc_Proporty_Static_DataLoadAll]");
            GetprocProcProportyStaticDataLoadAllListVm vm = new GetprocProcProportyStaticDataLoadAllListVm
            {
                ProcProportyStaticdata = _mapper.Map<IList<Proporty_Static_Data>, IList<GetProcProportyStaticDataLoadAllVm>>(ProcProportyStaticdata)
            };

            return vm;
        }
    }
}
