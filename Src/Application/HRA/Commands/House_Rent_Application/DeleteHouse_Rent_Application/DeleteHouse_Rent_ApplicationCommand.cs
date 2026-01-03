using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.House_Rent_Application.DeleteHouse_Rent_Application
{
    /// @author  Shimels Alem  DeleteCAttendaceAndOT_Approval stored procedure.
    
    public class DeleteHouse_Rent_ApplicationCommand : IRequest<IList<House_Rent_Application_ID>>
    {
        public System.Guid Rent_App_ID { get; set; }
     
    }
}
