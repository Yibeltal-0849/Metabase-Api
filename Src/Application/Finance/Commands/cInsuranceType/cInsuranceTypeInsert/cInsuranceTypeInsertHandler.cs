



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cInsuranceType.cInsuranceTypeInsert.cInsuranceTypeInsertCommand
{

    /// @author  Shimels Alem  c_InsuranceTypeInsert stored procedure.


    public class cInsuranceTypeInsertHandler : IRequestHandler<cInsuranceTypeInsertCommand, IList<CInsuranceType_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cInsuranceTypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CInsuranceType_Name>> Handle( cInsuranceTypeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CInsuranceType_Name> result = await _procedureAdabter
                .Execute<CInsuranceType_Name>("[FINA].c_InsuranceTypeInsert", request);
           

            return result;
        }
    }
}
 