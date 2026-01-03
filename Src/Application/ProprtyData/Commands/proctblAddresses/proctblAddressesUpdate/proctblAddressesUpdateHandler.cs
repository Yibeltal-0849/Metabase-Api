

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblAddresses.proctblAddressesUpdate.proctblAddressesUpdateCommand
{

    /// @author  Shimels Alem  proc_tblAddressesUpdate stored procedure.


    public class proctblAddressesUpdateHandler : IRequestHandler<proctblAddressesUpdateCommand, IList<tblAddresses_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblAddressesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblAddresses_id>> Handle( proctblAddressesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblAddresses_id> result = await _procedureAdabter
                .Execute<tblAddresses_id>("[ProprtyData].proc_tblAddressesUpdate", request);
           

            return result;
        }
    }
}
 