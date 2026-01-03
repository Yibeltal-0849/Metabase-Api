using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.CEmployee.CreateCEmployee
{
    public class CreateCEmployeeHandler : IRequestHandler<CreateCEmployeeCommand, IList<CEmployee_Employee_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreateCEmployeeHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CEmployee_Employee_Id>> Handle(CreateCEmployeeCommand request, CancellationToken cancellationToken)
        {
        string Emplyee_Type_Posting_Group = request.Emplyee_Type_Posting_Group;
        Guid User_ID = request.User_ID;
            Guid? Type_Employement = request.Type_Employement;
            string Payrole_No = request.Payrole_No;
            string TIN = request.TIN;
            string Leave = request.Leave;
            string FName = request.FName;
            string LName = request.LName;
            string MName = request.MName;
            string Address = request.Address;
            string email = request.email;
            string Mather_FullNme = request.Mather_FullNme;
            string HomePhone = request.HomePhone;
            string WorkPhone = request.WorkPhone;
            string IDNumber = request.IDNumber;
            string Photo = request.Photo;
            DateTime? BirthDate = request.BirthDate;
            Guid Marrage_Status = request.Marrage_Status;
            Guid Gender = request.Gender;
            Guid Country = request.Country;
            bool? Active = request.Active;
            DateTime? Hired = request.Hired;
            DateTime? Terminated = request.Terminated;
            DateTime? Rehired = request.Rehired;
            string Log = request.Log;
            string commitee_participation=request.commitee_participation;
            IList<CEmployee_Employee_Id> result = await _procedureAdabter
                .Execute<CEmployee_Employee_Id>("[HRA].[C_EmployeeInsert]",
               (nameof(User_ID), request.User_ID),
                (nameof(Type_Employement), Type_Employement),
                (nameof(Payrole_No), Payrole_No),
                (nameof(TIN), TIN),
                (nameof(FName), FName),
                (nameof(LName), LName),
                (nameof(MName), MName),
                (nameof(Address), Address),
                (nameof(email), email),
                (nameof(HomePhone), HomePhone),
                (nameof(WorkPhone), WorkPhone),
                (nameof(IDNumber), IDNumber),
                (nameof(Photo), Photo),
                (nameof(BirthDate), BirthDate),
                (nameof(Marrage_Status), Marrage_Status),
                (nameof(Gender), Gender),
                (nameof(Country), Country),
                (nameof(Active), Active),
                (nameof(Hired), Hired),
                (nameof(Terminated), Terminated),
                (nameof(Rehired), Rehired),
                (nameof(Log), Log),
                 (nameof(Leave), Leave),
                 (nameof(Mather_FullNme), Mather_FullNme),
                  (nameof(Emplyee_Type_Posting_Group), Emplyee_Type_Posting_Group),
                  (nameof(commitee_participation), commitee_participation)
                );

            return result;
        }

    }
}
