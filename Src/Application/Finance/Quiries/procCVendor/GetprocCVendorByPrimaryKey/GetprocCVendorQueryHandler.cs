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

namespace Application.Finance.Quiries.procCVendor.GetprocCVendorByPrimaryKey
{
    public class GetprocCVendorQueryHandler : IRequestHandler<GetprocCVendorByPrimaryKey, GetprocCVendorLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCVendorQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCVendorLoadAllListVm> Handle(GetprocCVendorByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CVendor> procCVendors = await _procedureAdabter
               .Execute<CVendor>("[FINA].[proc_C_VendorLoadByPrimaryKey]", request);
            GetprocCVendorLoadAllListVm vm = new GetprocCVendorLoadAllListVm
            {
                procCVendors = _mapper.Map<IList<CVendor>, IList<GetprocCVendorLoadAllVm>>(procCVendors)
            };

            return vm;
        }
    }
}
