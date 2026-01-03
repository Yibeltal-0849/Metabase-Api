using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Domain.Entities.HRA
{
    public class Proc_C_Employe_VacationAndSickTime
    {
        public long? id { get; set; }
        public string Employee_Id { get; set; }
        public bool? UseDefault { get; set; }
        public long? EmplyeeGetHours { get; set; }
        public bool? Receives_At_Begining { get; set; }
        public long? MaxVacationOrSick_Time { get; set; }

    }
}
