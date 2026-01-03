using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Employee_Bio_Info_Type.CreateEmployee_Bio_Info_Type
{
    /// @author  Shimels Alem  proc_Employee_Bio_Info_TypeInsert stored procedure.

    public class CreateEmployee_Bio_Info_TypeCommand : IRequest<IList<EmployeeBioInfoType_Bio_Type_ID>>
    {
        public string Bio_Type_ID { get; set; }
        public string Name { get; set; }
        public string Json_Meta_Data { get; set; }
        public Guid? Visable_For_Task { get; set; }
        public bool? IsActive { get; set; }
    }
}
