

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cPayFrequencyType.cPayFrequencyTypeUpdate.cPayFrequencyTypeUpdateCommand
{

    /// @author  Shimels Alem  c_PayFrequencyTypeUpdate stored procedure.


    public class cPayFrequencyTypeUpdateHandler : IRequestHandler<cPayFrequencyTypeUpdateCommand, IList<CPayFrequencyType_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cPayFrequencyTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CPayFrequencyType_Name>> Handle( cPayFrequencyTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CPayFrequencyType_Name> result = await _procedureAdabter
                .Execute<CPayFrequencyType_Name>("[FINA].c_PayFrequencyTypeUpdate", request);
           

            return result;
        }
    }
}
 