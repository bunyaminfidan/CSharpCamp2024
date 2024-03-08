
using System;
using MaskTrack.Business.Abstract;
using MaskTrack.Business.Concrete;
using MaskTrack.Entities.Concrete;

Console.WriteLine("Hello, World!");

Person person1 = new();
person1.Id = 1;
person1.FirstName = "Ben";
person1.LastName = "FIDAN";
person1.Age = 30;

PttManager pttManager = new PttManager(new CitizenManager());

pttManager.GiveMask(person1);



IApplicantService citizenManager = new CitizenManager();
IApplicantService foreignManager = new ForeignManager();

List<Person> citizenPersonList =  citizenManager.GetList();
List<Person> foreignPersonList = foreignManager.GetList();

foreach (var person in citizenPersonList)
{
    Console.WriteLine(person.FirstName + " already took a mask.");
}


Console.WriteLine(" ----------- ");


foreach (var person in foreignPersonList)
{
    Console.WriteLine(person.FirstName + " already took a mask.");
}
