using System;
using MaskTrack.Entities.Abstract;

namespace MaskTrack.Entities.Concrete;

public class Person : IEntity
{
    public Person()
	{
	}


	public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
	
}

