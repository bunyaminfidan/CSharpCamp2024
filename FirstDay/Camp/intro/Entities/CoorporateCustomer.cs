using System;
namespace intro.Entities;

public class CorporateCustomer : BaseCustomer
{
	public CorporateCustomer()
	{
	}

	public string Name { get; set; }
	public string TaxNumber { get; set; }
}

