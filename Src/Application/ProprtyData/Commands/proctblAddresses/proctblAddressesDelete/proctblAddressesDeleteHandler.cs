using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblAddresses.proctblAddressesDelete.proctblAddressesDeleteCommand
{

    /// @author  Shimels Alem  proc_tblAddressesDelete stored procedure.


    public class proctblAddressesDeleteHandler : IRequestHandler<proctblAddressesDeleteCommand, IList<tblAddresses_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblAddressesDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblAddresses_id>> Handle( proctblAddressesDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblAddresses_id> result = await _procedureAdabter
                .Execute<tblAddresses_id>("[ProprtyData].proc_tblAddressesDelete", request);
           

            return result;
        }
    }
}
  