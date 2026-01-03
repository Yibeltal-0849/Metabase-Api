using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Inventory.Quiries.proccItemClass.GetproccItemClassLoadAll;

namespace Application.Inventory.Quiries.proccItemClass.GetproccItemClassByPrimaryKey
{
    /// @author  Shimels Alem proc_c_ItemClassLoadByPrimaryKey stored procedure.

    public class GetproccItemClassByPrimaryKey : IRequest<GetproccItemClassLoadAllListVm>
    {
        public string Name { get; set; }
    }
}
