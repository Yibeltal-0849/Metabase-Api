using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.CFile.CFileUpdate.CFileUpdateCommand
{

	/// @author  Shimels Alem  C_FileUpdate stored procedure.


	public class CFileUpdateCommand : IRequest<IList<CFile_C_File_ID>>
	{
		public System.Guid C_File_ID { get; set; }
		public string AD_Table_ID { get; set; }
		public string AD_Record_ID { get; set; }
	}
		
		
		 
	}

