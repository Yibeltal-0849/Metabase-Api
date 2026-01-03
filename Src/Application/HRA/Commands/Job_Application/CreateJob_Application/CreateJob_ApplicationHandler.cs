using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Job_Application.CreateJob_Application
{
    public class CreateJob_ApplicationHandler : IRequestHandler<CreateJob_ApplicationCommand, IList<JobApplication_Job_AppID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreateJob_ApplicationHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JobApplication_Job_AppID>> Handle(CreateJob_ApplicationCommand request, CancellationToken cancellationToken)
        {
             string Job_AppID = request.Job_AppID;
             Guid? application_code = request.application_code;
             string First_Name = request.First_Name;
             string Last_Name = request.Last_Name;
             DateTime? Application_Date = request.Application_Date;
             DateTime? Birth_Date = request.Birth_Date;
             string Nationality = request.Nationality;
             string Address = request.Address;
             string Phone_Number = request.Phone_Number;
            string E_Mail = request.E_Mail;
             Guid? Application_Position = request.Application_Position;
             bool? Submited = request.Submited;
            Guid? Job_Application_Status = request.Job_Application_Status;
             byte[]? CV = request.CV;
             bool Are_you_currently_employed_here = request.Are_you_currently_employed_here;
             string Work_experience = request.Work_experience;
             float? Cumulative_GPA = request.Cumulative_GPA;
             IList<JobApplication_Job_AppID> result = await _procedureAdabter
                    .Execute<JobApplication_Job_AppID>("[HRA].[Job_ApplicationInsert]",
                    (nameof(Job_AppID), Job_AppID),
                    (nameof(application_code), application_code),
                    (nameof(First_Name), First_Name),
                    (nameof(Last_Name), Last_Name),
                    (nameof(Application_Date), Application_Date),
                    (nameof(Birth_Date), Birth_Date),
                    (nameof(Nationality), Nationality),
                    (nameof(Address), Address),
                    (nameof(Phone_Number), Phone_Number),
                    (nameof(E_Mail), E_Mail),
                    (nameof(Application_Position), Application_Position),
                    (nameof(Submited), Submited),
                    (nameof(Job_Application_Status), Job_Application_Status),
                    (nameof(CV), CV),
                    (nameof(Are_you_currently_employed_here), Are_you_currently_employed_here),
                    (nameof(Work_experience), Work_experience),
                    (nameof(Cumulative_GPA), Cumulative_GPA)
                    );

            return result;
        }

    }
}
