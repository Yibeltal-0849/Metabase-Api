using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.FixedAsset.Quiries.procFixedAssetRent.GetprocFixedAssetRentLoadAll;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Quiries.procFixedAssetRent.GetprocFixedAssetRentLoadByPrimaryKeyApplicationNumber
{
    public class GetprocFixedAssetRentQueryHandler : IRequestHandler<GetprocFixedAssetRentLoadByPrimaryKeyApplicationNumber, GetprocFixedAssetRentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocFixedAssetRentQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetRentLoadAllListVm> Handle(GetprocFixedAssetRentLoadByPrimaryKeyApplicationNumber request, CancellationToken cancellationToken)
        {
           
            IList<FixedAssetRent> procFixedAssetRents = await _procedureAdabter
               .Execute<FixedAssetRent>("[FixedAsset].[proc_Fixed_Asset_RentLoadByPrimaryKey_Application_Number]", request);
            GetprocFixedAssetRentLoadAllListVm vm = new GetprocFixedAssetRentLoadAllListVm
            {
                procFixedAssetRents = _mapper.Map<IList<FixedAssetRent>, IList<GetprocFixedAssetRentLoadAllVm>>(procFixedAssetRents)
            };

            return vm;
        }
    }
}
