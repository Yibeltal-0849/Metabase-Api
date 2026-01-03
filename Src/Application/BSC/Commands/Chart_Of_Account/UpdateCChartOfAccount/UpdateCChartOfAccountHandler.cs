using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.Chart_Of_Account.UpdateCChartOfAccount
{
    public class UpdateCChartOfAccountHandler : IRequestHandler<UpdateCChartOfAccountCommand, IList<Proc_C_Chart_Of_Account_Account_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateCChartOfAccountHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_C_Chart_Of_Account_Account_ID>> Handle(UpdateCChartOfAccountCommand request, CancellationToken cancellationToken)
        {
            string Account_ID = request.Account_ID;
            string Org_ID = request.Org_ID;
            string Description = request.Description;
            long? Account_Type = request.Account_Type;
            System.Guid?Branch = request.Branch;
            System.Guid?DIV = request.DIV;
            bool? Blocked = request.Blocked;
            string Parent = request.Parent;
            string Propose_Type = request.Propose_Type;
            double? Totaling = request.Totaling;
            bool? Direct_Posting = request.Direct_Posting;
            bool? Is_Debit = request.Is_Debit;
            bool? Is_Credit = request.Is_Credit;
            string Gen_Posting_Type = request.Gen_Posting_Type;
            string Gen_Bus_Posting_Group = request.Gen_Bus_Posting_Group;
            string TAX_Bus_Posting_Group = request.TAX_Bus_Posting_Group;
            string TAX_Prod_Posting_Group = request.TAX_Prod_Posting_Group;
            string Gen_Prod_Posting_Group = request.Gen_Prod_Posting_Group;
            string Default_IC_Partner_G_L_Acc_No = request.Default_IC_Partner_G_L_Acc_No;
            bool? Is_Balance_Sheet = request.Is_Balance_Sheet;
            DateTime? Last_Date_Modified = request.Last_Date_Modified;

            IList<Proc_C_Chart_Of_Account_Account_ID> result = await _procedureAdabter
                .Execute<Proc_C_Chart_Of_Account_Account_ID>("[BSC].[proc_c_Chart_Of_AccountUpdate]", (nameof(Account_ID), Account_ID), (nameof(Org_ID), Org_ID),
                (nameof(Description), Description), (nameof(Account_Type), Account_Type), (nameof(Branch), Branch),
                (nameof(DIV), DIV), (nameof(Blocked), Blocked), (nameof(Parent), Parent),
                (nameof(Propose_Type), Propose_Type), (nameof(Totaling), Totaling)
                , (nameof(Direct_Posting), Direct_Posting), (nameof(Is_Debit), Is_Debit), (nameof(Is_Credit), Is_Credit)
                , (nameof(Gen_Posting_Type), Gen_Posting_Type), (nameof(Gen_Bus_Posting_Group), Gen_Bus_Posting_Group),
                (nameof(TAX_Bus_Posting_Group), TAX_Bus_Posting_Group), (nameof(TAX_Prod_Posting_Group), TAX_Prod_Posting_Group)
                , (nameof(Gen_Prod_Posting_Group), Gen_Prod_Posting_Group), (nameof(Default_IC_Partner_G_L_Acc_No), Default_IC_Partner_G_L_Acc_No)
                , (nameof(Is_Balance_Sheet), Is_Balance_Sheet), (nameof(Last_Date_Modified), Last_Date_Modified));

            return result;
        }
    }
}
