using System;
using intro.Entities;

namespace intro.Business;

public class CourseManager

{


    Course[] courses = new Course[2];


    public CourseManager()
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

        courses[0] = course1;
        courses[1] = course2;
    }

    public Course[] GetAll()
    {
        return courses;
    }


}

