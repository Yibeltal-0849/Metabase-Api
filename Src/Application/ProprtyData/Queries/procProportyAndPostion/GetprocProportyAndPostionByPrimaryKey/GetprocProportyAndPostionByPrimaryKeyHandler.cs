using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.procProportyAndPostion.GetprocProportyAndPostionLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.procProportyAndPostion.GetprocProportyAndPostionByPrimaryKey
{
    public class GetprocProportyAndPostionByPrimaryKeyHandler : IRequestHandler<GetprocProportyAndPostionByPrimaryKey, GetprocProportyAndPostionListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocProportyAndPostionByPrimaryKeyHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocProportyAndPostionListVm> Handle(GetprocProportyAndPostionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Proporty_And_Postion> procProportyAndProstion = await _procedureAdabter
               .Execute<Proporty_And_Postion>("[ProprtyData].[proc_Proporty_And_PostionLoadByPrimaryKey]", request);
            GetprocProportyAndPostionListVm vm = new GetprocProportyAndPostionListVm
            {
                procProportyAndProstion = _mapper.Map<IList<Proporty_And_Postion>, IList<GetprocProportyAndPostionLoadAllVm>>(procProportyAndProstion)
            };

            return vm;
        }
    }
}
