using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procVendorPostingGroup.GetprocVendorPostingGroupLoadAll
{
    class GetprocVendorPostingGroupLoadAllQueryHandler : IRequestHandler<GetprocVendorPostingGroupLoadAllQuery, GetprocVendorPostingGroupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocVendorPostingGroupLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVendorPostingGroupLoadAllListVm> Handle(GetprocVendorPostingGroupLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<VendorPostingGroup> procVendorPostingGroups = await _procedureAdabter
               .Execute<VendorPostingGroup>("[FINA].[proc_Vendor_Posting_GroupLoadAll]");
            GetprocVendorPostingGroupLoadAllListVm vm = new GetprocVendorPostingGroupLoadAllListVm
            {
                procVendorPostingGroups = _mapper.Map<IList<VendorPostingGroup>, IList<GetprocVendorPostingGroupLoadAllVm>>(procVendorPostingGroups)
            };

            return vm;
        }
    }
}
