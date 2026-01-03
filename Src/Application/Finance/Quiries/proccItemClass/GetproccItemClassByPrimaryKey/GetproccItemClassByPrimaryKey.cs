using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccItemClass.GetproccItemClassLoadAll;

namespace Application.Finance.Quiries.proccItemClass.GetproccItemClassByPrimaryKey
{
    /// @author  Shimels Alem proc_C_FileLoadByPrimaryKey stored procedure.

    public class GetproccItemClassByPrimaryKey : IRequest<GetproccItemClassLoadAllListVm>
    {
        public string Name { get; set; }
    }
}
