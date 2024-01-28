﻿using System.ComponentModel.DataAnnotations;

namespace DmoPL.Models
{
	public class ForgetPasswordViewModel
	{
	

		[Required(ErrorMessage ="Email Is Required")]
		[EmailAddress(ErrorMessage ="Invalid Email")]
		public string Email { get; set; }
		
		
	}
}
