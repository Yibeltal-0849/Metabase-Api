using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.StoreItemActivityType.GetStoreItemActivityTypeLoadAll;

namespace Application.Inventory.Quiries.StoreItemActivityType.GetStoreItemActivityTypeByTaskIDAndOrgCode
{
    public class GetStoreItemActivityTypeByTaskIAndOrgCode : IRequest<GetStoreItemActivityTypeLoadAllListVm_Branch>
    {
        public System.Guid? Visable_For_Task_ID { get; set; }
        public System.Guid? Orgnization_Code { get; set; }
    }
}
