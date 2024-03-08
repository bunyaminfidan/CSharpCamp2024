// See https://aka.ms/new-console-template for more information
using intro.Business;
using intro.Entities;

Console.WriteLine("Hello there, World!");

CourseManager courseManager = new();

Course[] courses = courseManager.GetAll();

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Id);
    Console.WriteLine(courses[i].Name);
    Console.WriteLine(courses[i].Description);
    Console.WriteLine(courses[i].Price);

    Console.WriteLine("-----------------");
}