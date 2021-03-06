﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Web.Models
{
	public class User
	{
		/// <summary>
		/// The user's id.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// The user's username.
		/// </summary>
		[Required]
		[MaxLength(50)]
		public string Username { get; set; }

		/// <summary>
		/// The user's email.
		/// </summary>
		[Required]
		[MaxLength(50)]
		public string Email { get; set; }

		/// <summary>
		/// The user's firt name.
		/// </summary>
		[Required]
		[MaxLength(50)]
		public string FirstName { get; set; }

		/// <summary>
		/// The user's last name.
		/// </summary>
		[Required]
		[MaxLength(50)]
		public string LastName { get; set; }

		/// <summary>
		/// The user's birth date.
		/// </summary>
		[Required]
		public DateTime BirthDate { get; set; }

		/// <summary>
		/// The user's age.
		/// </summary>
		public int Age
		{
			get
			{
				int age = 0;
				age = DateTime.Now.Year - BirthDate.Year;
				if (DateTime.Now.DayOfYear < BirthDate.DayOfYear)
					age = age - 1;

				return age;
			}
		}

		/// <summary>
		/// The user's height (in inches).
		/// </summary>
		public int Height { get; set; }

		/// <summary>
		/// The user's current weight (in lbs.).
		/// </summary>
		public int CurrentWeight { get; set; }

		/// <summary>
		/// The user's target/desired weight (in lbs.).
		/// </summary>
		public int DesiredWeight { get; set; }

		public double BMI
		{
			get
			{
				double bmi = 0;
				bmi = Math.Round((703 * CurrentWeight) / (Math.Pow(Height, 2.0)),1);
				return bmi;

			}
		}

		/// <summary>
		/// The recommended number of calories the user should consume daily. Determined by goal set by user
		/// </summary>
		public int RecommendedDailyCaloricIntake { get; set; }
		
		/// <summary>
		/// The number of consecutive meals that the user has logged.
		/// </summary>
		public int MealStreak { get; set; }

        /// <summary>
        /// The user's password.
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// The user's salt.
        /// </summary>
        public string Salt { get; set; }

        /// <summary>
        /// The user's role.
        /// </summary>
        public string Role { get; set; }
    }
}
