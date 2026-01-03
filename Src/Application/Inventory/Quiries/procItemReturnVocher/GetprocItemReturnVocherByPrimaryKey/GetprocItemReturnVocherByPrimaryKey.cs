using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.procItemReturnVocher.GetprocItemReturnVocherLoadAll;

namespace Application.Inventory.Quiries.procItemReturnVocher.GetprocItemReturnVocherByPrimaryKey
{
    /// @author  Shimels Alem proc_Item_Return_VocherLoadByPrimaryKey stored procedure.

    public class GetprocItemReturnVocherByPrimaryKey : IRequest<GetprocItemReturnVocherLoadAllListVm>
    {
        public string Requsition_ID { get; set; }
    }
}
