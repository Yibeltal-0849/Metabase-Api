using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cInsuranceType.cInsuranceTypeDelete.cInsuranceTypeDeleteCommand
{

    /// @author  Shimels Alem  c_InsuranceTypeDelete stored procedure.


    public class cInsuranceTypeDeleteHandler : IRequestHandler<cInsuranceTypeDeleteCommand, IList<CInsuranceType_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cInsuranceTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CInsuranceType_Name>> Handle( cInsuranceTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CInsuranceType_Name> result = await _procedureAdabter
                .Execute<CInsuranceType_Name>("[FINA].c_InsuranceTypeDelete", request);
           

            return result;
        }
    }
}
  