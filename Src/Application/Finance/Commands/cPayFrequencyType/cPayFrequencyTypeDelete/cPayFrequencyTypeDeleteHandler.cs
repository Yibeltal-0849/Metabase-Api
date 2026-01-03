using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cPayFrequencyType.cPayFrequencyTypeDelete.cPayFrequencyTypeDeleteCommand
{

    /// @author  Shimels Alem  c_PayFrequencyTypeDelete stored procedure.


    public class cPayFrequencyTypeDeleteHandler : IRequestHandler<cPayFrequencyTypeDeleteCommand, IList<CPayFrequencyType_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cPayFrequencyTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CPayFrequencyType_Name>> Handle( cPayFrequencyTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CPayFrequencyType_Name> result = await _procedureAdabter
                .Execute<CPayFrequencyType_Name>("[FINA].c_PayFrequencyTypeDelete", request);
           
            return result;
        }
    }
}
  