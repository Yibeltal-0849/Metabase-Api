using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.EmployeeDoucment.CreateEmployeeDoucment
{
    public class CreateEmployeeDoucmentHandler : IRequestHandler<CreateEmployeeDoucmentCommand, IList<EmployeeDoucment_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreateEmployeeDoucmentHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<EmployeeDoucment_ID>> Handle(CreateEmployeeDoucmentCommand request, CancellationToken cancellationToken)
        {

            string Employee_Id = request.Employee_Id;
            Guid ID = request.ID;
            string Document_Name = request.Document_Name;
            string DocType = request.DocType;
            bool? IsDeleted = request.IsDeleted;
            byte[] Document_upload = request.Document_upload;
         string Penshion = request.Penshion;
            DateTime? Uploaded_Date = request.Uploaded_Date;
      
            
            IList<EmployeeDoucment_ID> result = await _procedureAdabter
                .Execute<EmployeeDoucment_ID>("[HRA].[proc_Emplyee_DocumentsInsert]",
                (nameof(Employee_Id), Employee_Id),
                (nameof(ID), ID),
                (nameof(Document_Name), Document_Name),
                (nameof(DocType), DocType),
                (nameof(IsDeleted), IsDeleted),
                (nameof(Document_upload), Document_upload),
                (nameof(Penshion), Penshion), 
                (nameof(Uploaded_Date), Uploaded_Date)
           
                );

            return result;
        }

    }
}
