using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.BankDetail.UpdateBankDetail
{
    public class UpdateBankDetailHandler : IRequestHandler<UpdateBankDetailCommand, IList<BankDetail_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateBankDetailHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BankDetail_id>> Handle(UpdateBankDetailCommand request, CancellationToken cancellationToken)
        {
            string bankid = request.bankid;         
            string Employee_Id = request.Employee_Id;
            string AccountNumber = request.AccountNumber;
            string BankName = request.BankName;
            string AccountHolderName = request.AccountHolderName;
            string BranchName = request.BranchName;
            string IFSCCode = request.IFSCCode;
            string SwiftCode = request.SwiftCode;
            string BankAddress = request.BankAddress;
            string Country = request.Country;
           // string BankDetail_Type_Posting_Group = request.BankDetail_Type_Posting_Group;
            IList<BankDetail_id> result = await _procedureAdabter
                .Execute<BankDetail_id>("[HRA].[proc_UpdateBankDetail]",
               (nameof(bankid), bankid),

                (nameof(Employee_Id), Employee_Id),
                (nameof(BankName), BankName),                
                (nameof(AccountNumber), AccountNumber),
                (nameof(AccountHolderName), AccountHolderName),
                (nameof(BranchName), BranchName),
                (nameof(IFSCCode), IFSCCode),
                (nameof(SwiftCode), SwiftCode),
                (nameof(BankAddress), BankAddress),
                (nameof(Country), Country)
               // (nameof(BankDetail_Type_Posting_Group), BankDetail_Type_Posting_Group)
                );

         
             

            return result;
        }
    }
}
