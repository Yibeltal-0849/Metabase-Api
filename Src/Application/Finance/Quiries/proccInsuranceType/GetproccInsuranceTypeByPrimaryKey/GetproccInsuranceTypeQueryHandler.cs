using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccInsuranceType.GetproccInsuranceTypeLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccInsuranceType.GetproccInsuranceTypeByPrimaryKey
{
    public class GetproccInsuranceTypeQueryHandler : IRequestHandler<GetproccInsuranceTypeByPrimaryKey, GetproccInsuranceTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccInsuranceTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccInsuranceTypeLoadAllListVm> Handle(GetproccInsuranceTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CInsuranceType> proccInsuranceTypes = await _procedureAdabter
               .Execute<CInsuranceType>("[FINA].[proc_c_InsuranceTypeLoadByPrimaryKey]", request);
            GetproccInsuranceTypeLoadAllListVm vm = new GetproccInsuranceTypeLoadAllListVm
            {
                proccInsuranceTypes = _mapper.Map<IList<CInsuranceType>, IList<GetproccInsuranceTypeLoadAllVm>>(proccInsuranceTypes)
            };

            return vm;
        }
    }
}
