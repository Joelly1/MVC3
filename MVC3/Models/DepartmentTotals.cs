using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC3.Models
{
	public class DepartmentTotals
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public int Total { set; get; }
	}
}