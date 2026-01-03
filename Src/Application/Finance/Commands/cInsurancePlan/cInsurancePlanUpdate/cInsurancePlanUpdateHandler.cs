

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cInsurancePlan.cInsurancePlanUpdate.cInsurancePlanUpdateCommand
{

    /// @author  Shimels Alem  c_InsurancePlanUpdate stored procedure.


    public class cInsurancePlanUpdateHandler : IRequestHandler<cInsurancePlanUpdateCommand, IList<CInsurancePlan_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cInsurancePlanUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CInsurancePlan_id>> Handle( cInsurancePlanUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CInsurancePlan_id> result = await _procedureAdabter
                .Execute<CInsurancePlan_id>("[FINA].c_InsurancePlanUpdate", request);
           
            return result;
        }
    }
}
 