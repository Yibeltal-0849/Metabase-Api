using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.procItemCategory.GetprocItemCategoryLoadAll;

namespace Application.Inventory.Quiries.procItemCategory.GetprocItemCategoryByPrimaryKey
{
    /// @author  Shimels Alem proc_Item_CategoryLoadByPrimaryKey stored procedure.

    public class GetprocItemCategoryByPrimaryKey : IRequest<GetprocItemCategoryLoadAllListVm>
    {
        public string Code { get; set; }
    }
}
