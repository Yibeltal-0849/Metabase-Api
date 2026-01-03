



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cInsurancePlan.cInsurancePlanInsert.cInsurancePlanInsertCommand
{

    /// @author  Shimels Alem  c_InsurancePlanInsert stored procedure.


    public class cInsurancePlanInsertHandler : IRequestHandler<cInsurancePlanInsertCommand, IList<CInsurancePlan_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cInsurancePlanInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CInsurancePlan_id>> Handle( cInsurancePlanInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CInsurancePlan_id> result = await _procedureAdabter
                .Execute<CInsurancePlan_id>("[FINA].c_InsurancePlanInsert", request);
           

            return result;
        }
    }
}
 