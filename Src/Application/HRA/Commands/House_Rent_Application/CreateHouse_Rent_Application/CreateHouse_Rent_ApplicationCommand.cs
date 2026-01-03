using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.House_Rent_Application.CreateHouse_Rent_Application
{
    /// @author  Shimels Alem  CreateCAttendaceAndOT_Approval stored procedure.
    
    public class CreateHouse_Rent_ApplicationCommand : IRequest<IList<House_Rent_Application_ID>>
    {
        public System.Guid Rent_App_ID { get; set; }
        public System.Guid? Customer_Code { get; set; }
        public System.Guid Postion { get; set; }
        public System.Guid? Application_Date { get; set; }
        public bool? Is_Approved { get; set; }
        public Int64 Queue_number { get; set; }
        public string Orgnization_Name_Eng { get; set; }
        public string Orgnization_Name_Am { get; set; }
    }
}
