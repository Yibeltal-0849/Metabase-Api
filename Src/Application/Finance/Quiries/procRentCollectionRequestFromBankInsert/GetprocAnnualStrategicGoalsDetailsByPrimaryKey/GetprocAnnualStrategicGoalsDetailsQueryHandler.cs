using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procRentCollectionRequestFromBankInsert.GetRentCollectionRequestFromBankLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procRentCollectionRequestFromBankInsert.GetprocAnnualStrategicGoalsDetailsByPrimaryKey
{
    public class GetprocAnnualStrategicGoalsDetailsQueryHandler : IRequestHandler<GetRentCollectionRequestFromBankByPrimaryKey, GetRentCollectionRequestFromBankLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocAnnualStrategicGoalsDetailsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetRentCollectionRequestFromBankLoadAllListVm> Handle(GetRentCollectionRequestFromBankByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList<RentCollectionRequestFromBank> procRentCollectionRequestFromBank = await _procedureAdabter
               .Execute<RentCollectionRequestFromBank>("[FINA].[proc_Rent_Collection_Request_From_BankLoadByPrimaryKey]", request);
            GetRentCollectionRequestFromBankLoadAllListVm vm = new GetRentCollectionRequestFromBankLoadAllListVm
            {
                procRentCollectionRequestFromBank = _mapper.Map<IList<RentCollectionRequestFromBank>, IList<GetRentCollectionRequestFromBankLoadAllVm>>(procRentCollectionRequestFromBank)
            };

            return vm;
        }
    }
}
