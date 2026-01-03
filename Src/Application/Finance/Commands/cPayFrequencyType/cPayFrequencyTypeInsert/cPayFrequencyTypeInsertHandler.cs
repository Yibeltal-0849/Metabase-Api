



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cPayFrequencyType.cPayFrequencyTypeInsert.cPayFrequencyTypeInsertCommand
{

    /// @author  Shimels Alem  c_PayFrequencyTypeInsert stored procedure.


    public class cPayFrequencyTypeInsertHandler : IRequestHandler<cPayFrequencyTypeInsertCommand, IList<CPayFrequencyType_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cPayFrequencyTypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CPayFrequencyType_Name>> Handle( cPayFrequencyTypeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CPayFrequencyType_Name> result = await _procedureAdabter
                .Execute<CPayFrequencyType_Name>("[FINA].c_PayFrequencyTypeInsert", request);
           

            return result;
        }
    }
}
 