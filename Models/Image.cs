﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class Image
	{
		[Required]
		public byte[] ImageData { get; set; }
		[Required]
		[MaxLength(255)]
		public string FileName { get; set; }
		[Required]
		[MaxLength(255)]
		public string ContentType { get; set; }
	}
}
