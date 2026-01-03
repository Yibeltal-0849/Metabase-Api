using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.BankDetail
{
    class GetBankDetailLoadAllQueryHandler : IRequestHandler<GetBankDetailLoadAllQuery, GetBankDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetBankDetailLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetBankDetailLoadAllListVm> Handle(GetBankDetailLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<bankDetail> BankDetails = await _procedureAdabter
               .Execute<bankDetail>("[HRA].[proc_GetAllBankDetails]");
            GetBankDetailLoadAllListVm vm = new GetBankDetailLoadAllListVm
            {
                BankDetails = _mapper.Map<IList<bankDetail>, IList<GetBankDetailLoadAllVm>>(BankDetails)
            };

            return vm;
        }
    }
}
