using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccUnit.GetproccUnitLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccUnit.GetproccUnitByPrimaryKey
{
    public class GetproccUnitQueryHandler : IRequestHandler<GetproccUnitByPrimaryKey, GetproccUnitLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccUnitQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccUnitLoadAllListVm> Handle(GetproccUnitByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CUnit> proccUnits = await _procedureAdabter
               .Execute<CUnit>("[FINA].[proc_c_UnitLoadByPrimaryKey]", request);
            GetproccUnitLoadAllListVm vm = new GetproccUnitLoadAllListVm
            {
                proccUnits = _mapper.Map<IList<CUnit>, IList<GetproccUnitLoadAllVm>>(proccUnits)
            };

            return vm;
        }
    }
}
