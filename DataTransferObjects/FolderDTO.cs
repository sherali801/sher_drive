﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjects
{
	public class FolderDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int ParentFolderId { get; set; }
		public string ParentFolderName { get; set; }
		public int CreatedBy { get; set; }
		public DateTime CreatedOn { get; set; }
		public bool IsActive { get; set; }
	}
}
