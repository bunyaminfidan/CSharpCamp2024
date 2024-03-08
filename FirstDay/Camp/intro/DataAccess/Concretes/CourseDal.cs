﻿using System;
using intro.DataAccess.Abstracts;
using intro.Entities;

namespace intro.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> courses;
	public CourseDal()
	{

        Course course1 = new();
        Course course2 = new();

        course1.Id = 1;
        course1.Name = "C# Bootcamp";
        course1.Description = "You will learn basic C# and algroritm";
        course1.Price = 25.99;

        course2.Id = 2;
        course2.Name = "Java Bootcamp";
        course2.Description = "You will learn basic Java and algroritm";
        course2.Price = 35.99;

        courses = new List<Course> { course1, course2 };
    }

	public List<Course> GetAll()
	{

        //Db code will be here
        //sql


        return courses;
	}


    public void Add (Course course)
    {
        courses.Add(course);
    } 


}

