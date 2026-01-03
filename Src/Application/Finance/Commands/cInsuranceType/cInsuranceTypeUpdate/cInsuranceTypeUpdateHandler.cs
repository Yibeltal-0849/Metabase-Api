

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cInsuranceType.cInsuranceTypeUpdate.cInsuranceTypeUpdateCommand
{

    /// @author  Shimels Alem  c_InsuranceTypeUpdate stored procedure.


    public class cInsuranceTypeUpdateHandler : IRequestHandler<cInsuranceTypeUpdateCommand, IList<CInsuranceType_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cInsuranceTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CInsuranceType_Name>> Handle( cInsuranceTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CInsuranceType_Name> result = await _procedureAdabter
                .Execute<CInsuranceType_Name>("[FINA].c_InsuranceTypeUpdate", request);
           

            return result;
        }
    }
}
 