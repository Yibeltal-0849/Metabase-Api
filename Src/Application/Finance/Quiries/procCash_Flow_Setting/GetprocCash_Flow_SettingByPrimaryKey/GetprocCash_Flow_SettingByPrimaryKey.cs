using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procCash_Flow_Setting.GetprocCash_Flow_SettingLoadAll;

namespace Application.Finance.Quiries.procCash_Flow_Setting.GetprocCash_Flow_SettingByPrimaryKey
{
    /// @author  Shimels Alem proc_c_Account_CatLoadByPrimaryKey stored procedure.

    public class GetprocCash_Flow_SettingByPrimaryKey : IRequest<GetprocCash_Flow_SettingLoadAllListVm>
    {
        public string ID { get; set; }
       
    }
}
