using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procLGLRegisters.GetprocLGLRegistersLoadAll;

namespace Application.Finance.Quiries.procLGLRegisters.GetprocLGLRegistersByPrimaryKey
{
    /// @author  Shimels Alem proc_L_G_L_RegistersLoadByPrimaryKey stored procedure.

    public class GetprocLGLRegistersByPrimaryKey : IRequest<GetprocLGLRegistersLoadAllListVm>
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Period { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public System.Int64 To_VAT_Entry_No { get; set; }
    }
}
