 

using AutoMapper;
using MediatR; 
using Application.Finance.Quiries.procAdBusinessType.GetprocAdBusinessTypeLoadAll;

namespace Application.Finance.Quiries.procAdBusinessType.GetprocAdBusinessTypeLoadByPrimaryKey
{ 
	 
	#region procAdBusinessTypeLoadByPrimaryKey  
      public class GetprocAdBusinessTypeLoadByPrimaryKey : IRequest<GetprocAdBusinessTypeLoadAllListVM>
    {
        public long Id { get; set; }

    }



    #endregion




}

