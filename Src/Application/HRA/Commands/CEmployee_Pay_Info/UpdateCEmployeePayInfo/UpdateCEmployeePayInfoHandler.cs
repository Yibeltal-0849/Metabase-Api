using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.CEmployee_Pay_Info.UpdateCEmployeePayInfo
{
    public class UpdateCEmployeePayInfoHandler : IRequestHandler<UpdateCEmployeePayInfoCommand, IList<CEmployeePayInfo_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateCEmployeePayInfoHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CEmployeePayInfo_id>> Handle(UpdateCEmployeePayInfoCommand request, CancellationToken cancellationToken)
        {
            long id = request.id;
            string orgCode = request.orgcode;
            string Employee_ID = request.Employee_Id;
            string Pay_Type = request.Pay_Type;
            bool? UseDefault = request.UseDefault;
            string Pay_Frequency = request.Pay_Frequency;
            string GL_Account = request.GL_Account;
            decimal Salary_Hour_Pay = request.Salary_Hour_Pay;

            IList<CEmployeePayInfo_id> result = await _procedureAdabter
                .Execute<CEmployeePayInfo_id>("[HRA].[proc_c_EmployeePayInfoUpdate]",
                 (nameof(id), id),
                (nameof(orgCode), orgCode),
                (nameof(Employee_ID), Employee_ID),
                (nameof(Pay_Type), Pay_Type),
                (nameof(UseDefault), UseDefault),
                (nameof(Pay_Frequency), Pay_Frequency),
                (nameof(GL_Account), GL_Account),
                (nameof(Salary_Hour_Pay), Salary_Hour_Pay));

            return result;
        }
    }
}
