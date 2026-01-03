using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.procReciveRent.GetprocReciveRentLoadAll;


namespace Application.Purchase.Quiries.procReciveRent.GetprocReciveRentByPrimaryKey
{
    public class GetprocReciveRentByPrimaryKey : IRequest<GetprocReciveRentLoadAllListVm>
                                                          
    {
        public System.Guid Rent_Collection_ID { get; set; }
    }
}
