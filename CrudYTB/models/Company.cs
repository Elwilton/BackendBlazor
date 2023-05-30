using System;
using System.ComponentModel.DataAnnotations;

namespace CrudYTB.models
{
	public class Company
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string? Name { get; set; }

        [Required]
        [MaxLength(13)]
        public string? Phone { get; set; }

		public void GeneratedNewId()
		{
			Id = Guid.NewGuid();
		}
	}
}

