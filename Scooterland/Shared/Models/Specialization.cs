﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Scooterland.Shared.Models
{
	public class Specialization
	{
		public int SpecializationId { get; set; }
		[MaxLength(30, ErrorMessage = "Brand navn må maksimalt være 30 tegn lang!")]
		public string Brand { get; set; }
		[JsonIgnore]
		public List<Employee> Employees { get; set; } = new List<Employee>();
		//Tom contructor til EF
		public Specialization()
        {
            
        }
		public Specialization(int id)
		{
			this.SpecializationId = id;
		}
	}
}
