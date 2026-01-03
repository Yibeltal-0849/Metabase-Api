


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceStatus.proctblResourceStatusInsert.proctblResourceStatusInsertCommand
{

    /// @author  Shimels Alem  proc_tblResource_StatusInsert stored procedure.


    public class proctblResourceStatusInsertCommand : IRequest<IList<tblResourceStatus_id>>
    {
        public long? id { get; set; }
        public string Status { get; set; }
        public bool? Enable { get; set; }

    }



}
 
 