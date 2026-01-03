using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Commands.procAdjudicated.procAdjudicatedUpdate
{
    public class procAdjudicatedUpdateCommand : IRequest<IList<AdjudicatedCode>>
    {
        public System.Guid? Adjudicated_Code { get; set; }
        public System.Guid? application_code { get; set; }
        public string Plot_ID { get; set; }
        public System.DateTime? Adjudicated_Date { get; set; }
        public string Remark { get; set; }
        public bool IS_Adjudicated { get; set; }
    }
}
