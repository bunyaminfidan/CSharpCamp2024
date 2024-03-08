﻿using System;
namespace intro.Entities;

public class IndividualCustomer : BaseCustomer
{
	public IndividualCustomer()
	{
	}


	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string NationalIdentity { get; set; }
}
