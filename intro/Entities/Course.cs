using System;
namespace intro.Entities;

public class Course
{
	public Course()
	{
	}

	public int Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public double Price { get; set; }
}

