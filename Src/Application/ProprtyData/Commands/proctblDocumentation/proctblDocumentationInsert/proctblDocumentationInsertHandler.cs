



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblDocumentation.proctblDocumentationInsert.proctblDocumentationInsertCommand
{

    /// @author  Shimels Alem  proc_tblDocumentationInsert stored procedure.


    public class proctblDocumentationInsertHandler : IRequestHandler<proctblDocumentationInsertCommand, IList<tblDocumentation_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblDocumentationInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblDocumentation_id>> Handle( proctblDocumentationInsertCommand request, CancellationToken cancellationToken)
        {
             long? id = request.id;
             long? Region = request.Region;
             string Contact_Person = request.Contact_Person;
             string Contact_Phone = request.Contact_Phone;
             long? Type = request.Type;
             System.Guid? Created_Date = request.Created_Date;
             long? Created_By = request.Created_By;
             System.DateTime? Update_Date = request.Update_Date;
             long? Update_by = request.Update_by;
             byte[]? Last_Modified = request.Last_Modified;
             bool? Enable = request.Enable;
             string Data_Owner = request.Data_Owner;
             bool? Regional_Approve = request.Regional_Approve;
             bool? Federal_Approve = request.Federal_Approve;

        IList<tblDocumentation_id> result = await _procedureAdabter
                .Execute<tblDocumentation_id>("[ProprtyData].proc_tblDocumentationInsert",
                (nameof(id), id),
                (nameof(Region), Region),
                (nameof(Contact_Person), Contact_Person),
                (nameof(Contact_Phone), Contact_Phone),
                (nameof(Type), Type),
                (nameof(Created_Date), Created_Date),
                (nameof(Created_By), Created_By),
                (nameof(Update_Date), Update_Date),
                (nameof(Update_by), Update_by),
                (nameof(Last_Modified), Last_Modified),
                (nameof(Enable), Enable),
                (nameof(Data_Owner), Data_Owner),
                (nameof(Regional_Approve), Regional_Approve),
                (nameof(Federal_Approve), Federal_Approve)
                );
           

            return result;
        }
    }
}
 