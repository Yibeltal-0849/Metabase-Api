using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procFixedAssetRent.GetprocFixedAssetRentLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procFixedAssetRent.GetprocFixedAssetRentByPrimaryKey
{
    public class GetprocFixedAssetRentQueryHandler : IRequestHandler<GetprocFixedAssetRentByPrimaryKey, GetprocFixedAssetRentLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocFixedAssetRentQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetRentLoadAllListVm> Handle(GetprocFixedAssetRentByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<FixedAssetRent> procFixedAssetRents = await _procedureAdabter
               .Execute<FixedAssetRent>("[FINA].[proc_C_FidleLoadByPrimaryKey]", request);
            GetprocFixedAssetRentLoadAllListVm vm = new GetprocFixedAssetRentLoadAllListVm
            {
                procFixedAssetRents = _mapper.Map<IList<FixedAssetRent>, IList<GetprocFixedAssetRentLoadAllVm>>(procFixedAssetRents)
            };

            return vm;
        }
    }
}
