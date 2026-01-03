using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.VendorPostingGroup.VendorPostingGroupDelete.VendorPostingGroupDeleteCommand
{

    /// @author  Shimels Alem  Vendor_Posting_GroupDelete stored procedure.


    public class VendorPostingGroupDeleteHandler : IRequestHandler<VendorPostingGroupDeleteCommand, IList<VendorPostingGroup_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public VendorPostingGroupDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VendorPostingGroup_Code>> Handle( VendorPostingGroupDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<VendorPostingGroup_Code> result = await _procedureAdabter
                .Execute<VendorPostingGroup_Code>("[FINA].Vendor_Posting_GroupDelete", request);
           

            return result;
        }
    }
}
  