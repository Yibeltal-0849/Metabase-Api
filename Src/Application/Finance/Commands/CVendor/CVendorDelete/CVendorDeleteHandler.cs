using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.CVendor.CVendorDelete.CVendorDeleteCommand
{

    /// @author  Shimels Alem  C_VendorDelete stored procedure.


    public class CVendorDeleteHandler : IRequestHandler<CVendorDeleteCommand, IList<CVendor_Vendor_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CVendorDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CVendor_Vendor_ID>> Handle( CVendorDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CVendor_Vendor_ID> result = await _procedureAdabter
                .Execute<CVendor_Vendor_ID>("[FINA].C_VendorDelete", request);
           

            return result;
        }
    }
}
  