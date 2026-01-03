 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Common.Mappings;
using System;

namespace Application.Finance.Quiries.procADOrg
{ 
	 
	#region procADOrgLoadAll  
    
      public class GetprocADOrgLoadAllVM : IMapFrom<GetprocADOrgLoadAllVM>
    {
		public string _code     { get; set; }
		public System.Guid? _organizationCode     { get; set; }
		public string _name     { get; set; }
		public string _address     { get; set; }
		public string _country     { get; set; }
		public string _telephone     { get; set; }
		public string _fax     { get; set; }
		public string _tin     { get; set; }
		public string _vat     { get; set; }
		public string _employerFederalID     { get; set; }
		public string _employerReginalID     { get; set; }
		public long? _businessType     { get; set; }
		public string _webSite     { get; set; }
		public string _email     { get; set; }
		public byte[] _logo     { get; set; }
		public long? _accountingMethod     { get; set; }
    
        public void Mapping(Profile profile)
        {
            profile.CreateMap<AdOrg, GetprocADOrgLoadAllVM>();
        }
    }
    #endregion  
}

