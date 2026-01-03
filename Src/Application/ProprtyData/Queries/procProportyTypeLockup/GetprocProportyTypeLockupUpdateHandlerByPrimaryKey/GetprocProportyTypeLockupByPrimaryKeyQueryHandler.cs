using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.procProportyTypeLockup.GetprocProportyTypeLockupHandlerLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.procProportyTypeLockup.GetprocProportyDataCollectionTransactionByPrimaryKey
{
    public class GetprocProportyTypeLockupByPrimaryKeyQueryHandler : IRequestHandler<GetprocProportyTypeLockupByPrimaryKey, GetprocProportyTypeLockupListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocProportyTypeLockupByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocProportyTypeLockupListVm> Handle(GetprocProportyTypeLockupByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Proporty_Type_LookUp> procProportyType = await _procedureAdabter
               .Execute<Proporty_Type_LookUp>("[ProprtyData].[proc_Property_Type_LookupLoadByPrimaryKey]", request);
            GetprocProportyTypeLockupListVm vm = new GetprocProportyTypeLockupListVm
            {
                procProportyType = _mapper.Map<IList<Proporty_Type_LookUp>, IList<GetprocProportyTypeLockupLoadAllVm>>(procProportyType)
            };

            return vm;
        }
    }
}
