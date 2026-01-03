using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccUnit.GetproccUnitLoadAll
{
    class GetproccUnitLoadAllQueryHandler : IRequestHandler<GetproccUnitLoadAllQuery, GetproccUnitLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccUnitLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccUnitLoadAllListVm> Handle(GetproccUnitLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CUnit> proccUnits = await _procedureAdabter
               .Execute<CUnit>("[FINA].[proc_c_UnitLoadAll]");
            GetproccUnitLoadAllListVm vm = new GetproccUnitLoadAllListVm
            {
                proccUnits = _mapper.Map<IList<CUnit>, IList<GetproccUnitLoadAllVm>>(proccUnits)
            };

            return vm;
        }
    }
}
