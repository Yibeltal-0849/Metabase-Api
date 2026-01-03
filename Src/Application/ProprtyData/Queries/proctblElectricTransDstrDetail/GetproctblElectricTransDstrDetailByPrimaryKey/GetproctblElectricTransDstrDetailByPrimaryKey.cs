using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblElectricTransDstrDetail.GetproctblElectricTransDstrDetailLoadAll;

namespace Application.ProprtyData.Queries.proctblElectricTransDstrDetail.GetproctblElectricTransDstrDetailByPrimaryKey
{
    /// @author  Shimels Alem proc_tblElectric_Trans_Dstr_DetailLoadByPrimaryKey stored procedure.

    public class GetproctblElectricTransDstrDetailByPrimaryKey : IRequest<GetproctblElectricTransDstrDetailLoadAllListVm>
    {
        public long id { get; set; }
    }
}
