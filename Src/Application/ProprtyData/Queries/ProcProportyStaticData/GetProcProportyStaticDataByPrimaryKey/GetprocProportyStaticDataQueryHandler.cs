using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.ProcProportyStaticData.GetprocProcProportyStaticDataLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;
using Application.ProprtyData.Queries.ProcProportyStaticData;

namespace Application.ProprtyData.Queries.procProportyStaticData.GetprocProportyStaticDataByPrimaryKey
{
    public class GetprocProportyStaticDataQueryHandler : IRequestHandler<GetprocProportyStaticDataByPrimaryKey, GetprocProcProportyStaticDataLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocProportyStaticDataQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocProcProportyStaticDataLoadAllListVm> Handle(GetprocProportyStaticDataByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Proporty_Static_Data> ProcProportyStaticdata = await _procedureAdabter
               .Execute<Proporty_Static_Data>("[ProprtyData].[proc_Proporty_Static_DataLoadByPrimaryKey]", request);
            GetprocProcProportyStaticDataLoadAllListVm vm = new GetprocProcProportyStaticDataLoadAllListVm
            {
                ProcProportyStaticdata = _mapper.Map<IList<Proporty_Static_Data>, IList<GetProcProportyStaticDataLoadAllVm>>(ProcProportyStaticdata)
            };

            return vm;
        }
    }
}
