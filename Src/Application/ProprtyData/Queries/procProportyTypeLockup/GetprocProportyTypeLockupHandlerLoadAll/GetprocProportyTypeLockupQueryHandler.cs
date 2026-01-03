using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.procProportyTypeLockup.GetprocProportyTypeLockupHandlerLoadAll
{
    class GetprocProportyTypeLockupQueryHandler : IRequestHandler<GetprocProportyTypeLockupQuery, GetprocProportyTypeLockupListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocProportyTypeLockupQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocProportyTypeLockupListVm> Handle(GetprocProportyTypeLockupQuery request, CancellationToken cancellationToken)
        {
            IList<Proporty_Type_LookUp> procProportyType = await _procedureAdabter
               .Execute<Proporty_Type_LookUp>("[ProprtyData].[proc_Property_Type_LookupLoadAll]");
            GetprocProportyTypeLockupListVm vm = new GetprocProportyTypeLockupListVm
            {
                procProportyType = _mapper.Map<IList<Proporty_Type_LookUp>, IList<GetprocProportyTypeLockupLoadAllVm>>(procProportyType)
            };

            return vm;
        }
    }
}
