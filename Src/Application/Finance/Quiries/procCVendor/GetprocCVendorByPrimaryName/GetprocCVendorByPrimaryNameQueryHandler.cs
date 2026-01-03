using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procCVendor.GetprocCVendorLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procCVendor.GetprocCVendorByPrimaryName
{
    public class GetprocCVendorByPrimaryNameQueryHandler : IRequestHandler<GetprocCVendorByPrimaryName, GetprocCVendorLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCVendorByPrimaryNameQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCVendorLoadAllListVm> Handle(GetprocCVendorByPrimaryName request, CancellationToken cancellationToken)
        {
           
            IList<CVendor> procCVendors = await _procedureAdabter
               .Execute<CVendor>("[FINA].[proc_C_VendorLoadByName]", request);
            GetprocCVendorLoadAllListVm vm = new GetprocCVendorLoadAllListVm
            {
                procCVendors = _mapper.Map<IList<CVendor>, IList<GetprocCVendorLoadAllVm>>(procCVendors)
            };

            return vm;
        }
    }
}
