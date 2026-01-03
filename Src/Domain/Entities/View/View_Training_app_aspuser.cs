using System;

namespace XOKA.Domain.Entities.view
{
    public  class View_Training_app_aspuser
    {
        public string application_number { get; set; }
        public Guid? UserId { get; set; }
        public Guid? Training_Planed_ID { get; set; }
        public string? Employee_ID { get; set; }

    }
}
