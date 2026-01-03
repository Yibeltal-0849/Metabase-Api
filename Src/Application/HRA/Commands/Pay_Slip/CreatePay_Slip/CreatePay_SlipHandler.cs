using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Pay_Slip.CreatePay_Slip
{
    public class CreatePay_SlipHandler : IRequestHandler<CreatePay_SlipCommand, IList<PaySlip_Pay_Slip_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreatePay_SlipHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PaySlip_Pay_Slip_ID>> Handle(CreatePay_SlipCommand request, CancellationToken cancellationToken)
        {
             Guid? Pay_Slip_ID = request.Pay_Slip_ID;
             Guid? Payrole_Trans_Id = request.Payrole_Trans_Id;
             Guid? Work_Info = request.Work_Info;
             string Employee_ID = request.Employee_ID;
             string Payroll_NO = request.Payroll_NO;
             string Full_Name = request.Full_Name;
             string Job_Title = request.Job_Title;
             double? Basic_Salary = request.Basic_Salary;
             double? Total_Working_Days = request.Total_Working_Days;
             double? Absent_Yearly_Leave_With_Pay = request.Absent_Yearly_Leave_With_Pay;
             double? Absent_Yearly_Leave_Without_Pay = request.Absent_Yearly_Leave_Without_Pay;
             double? Absent_Sick_Leave = request.Absent_Sick_Leave;
             double? Absent_in_other_Typeof_Leave = request.Absent_in_other_Typeof_Leave;
             double? Absent_Weekend_And_Holiday = request.Absent_Weekend_And_Holiday;
             double? Absent_With_Out_Approval = request.Absent_With_Out_Approval;
             double? Net_Working_Days = request.Net_Working_Days;
             double? OT_Price = request.OT_Price;
             double? Addistion_Before_Tax = request.Addistion_Before_Tax;
             double? Deduction_Before_Tax = request.Deduction_Before_Tax;
             string Addistion_After_tax = request.Addistion_After_tax;
             string Deduction_After_Tax = request.Deduction_After_Tax;
             double? Inc_Tax = request.Inc_Tax;
             double? Pen_Tax = request.Pen_Tax;
             double? Pen_From_Company = request.Pen_From_Company;
             double? Other_Didaction = request.Other_Didaction;
             string Bank_Account_No = request.Bank_Account_No;
             double? Net_Salary = request.Net_Salary;
             bool? IS_Payed = request.IS_Payed;

             IList<PaySlip_Pay_Slip_ID> result = await _procedureAdabter
                .Execute<PaySlip_Pay_Slip_ID>("[HRA].[Pay_SlipInsert]",
                (nameof(Pay_Slip_ID), Pay_Slip_ID),
                (nameof(Payrole_Trans_Id), Payrole_Trans_Id),
                (nameof(Work_Info), Work_Info),
                (nameof(Employee_ID), Employee_ID),
                (nameof(Payroll_NO), Payroll_NO),
                (nameof(Full_Name), Full_Name),
                (nameof(Job_Title), Job_Title),
                (nameof(Basic_Salary), Basic_Salary),
                (nameof(Total_Working_Days), Total_Working_Days),
                (nameof(Absent_Yearly_Leave_With_Pay), Absent_Yearly_Leave_With_Pay),
                (nameof(Absent_Yearly_Leave_Without_Pay), Absent_Yearly_Leave_Without_Pay),
                (nameof(Absent_Sick_Leave), Absent_Sick_Leave),
                (nameof(Absent_in_other_Typeof_Leave), Absent_in_other_Typeof_Leave),
                (nameof(Absent_Weekend_And_Holiday), Absent_Weekend_And_Holiday),
                (nameof(Absent_With_Out_Approval), Absent_With_Out_Approval),
                (nameof(Net_Working_Days), Net_Working_Days),
                (nameof(OT_Price), OT_Price),
                (nameof(Addistion_Before_Tax), Addistion_Before_Tax),
                (nameof(Deduction_Before_Tax), Deduction_Before_Tax),
                (nameof(Addistion_After_tax), Addistion_After_tax),
                (nameof(Deduction_After_Tax), Deduction_After_Tax),
                (nameof(Inc_Tax), Inc_Tax),
                (nameof(Pen_Tax), Pen_Tax),
                (nameof(Pen_From_Company), Pen_From_Company),
                (nameof(Other_Didaction), Other_Didaction),
                (nameof(Bank_Account_No), Bank_Account_No),
                (nameof(Net_Salary), Net_Salary),
                (nameof(IS_Payed), IS_Payed));

            return result;
        }

    }
}
