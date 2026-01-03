using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccCostMethod.GetproccCostMethodLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccCostMethod.GetproccCostMethodByPrimaryKey
{
    public class GetproccCostMethodQueryHandler : IRequestHandler<GetproccCostMethodByPrimaryKey, GetproccCostMethodLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccCostMethodQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccCostMethodLoadAllListVm> Handle(GetproccCostMethodByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CCostMethod> proccCostMethods = await _procedureAdabter
               .Execute<CCostMethod>("[FINA].[proc_c_Cost_MethodLoadByPrimaryKey]", request);
            GetproccCostMethodLoadAllListVm vm = new GetproccCostMethodLoadAllListVm
            {
                proccCostMethods = _mapper.Map<IList<CCostMethod>, IList<GetproccCostMethodLoadAllVm>>(proccCostMethods)
            };

            return vm;
        }
    }
}
