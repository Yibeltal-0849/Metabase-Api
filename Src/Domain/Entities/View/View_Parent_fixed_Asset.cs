using System;

namespace XOKA.Domain.Entities.view
{
    public class View_Parent_fixed_Asset
    {

        public System.Guid lkdetail_code { get; set; }
        public System.Guid lkmaster_master_code { get; set; }
        public string english_description { get; set; }
        public string amharic_description { get; set; }
        public string tigrigna_description { get; set; }
        public string oromiffa_description { get; set; }
        public System.Guid Parent { get; set; }


    }
}
