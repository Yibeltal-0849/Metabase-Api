using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.ProcGeneratePaySlip.PostUspGeneratePaySlipForAll
{
    /// @author  Shimels Alem  DeleteCAttendaceAndOT_Approval stored procedure.
    
    public class PostUspGeneratePaySlipForAllCommand : IRequest<IList<UspGeneratePaySlip>>
    {
        public string Payrole_Trans_Id { get; set; }
    }
}
