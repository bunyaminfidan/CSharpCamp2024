using System;
using MaskTrack.Business.Abstract;
using MaskTrack.Entities.Concrete;

namespace MaskTrack.Business.Concrete;

	public class ForeignManager : IApplicantService
{
    List<Person> personList = new();
    public ForeignManager()
		{

        Person person1 = new Person();
        Person person2 = new Person();
        person1.Id = 1;
        person1.FirstName = "Conor";
        person1.LastName = "Con";
        person1.Age = 30;

        person2.Id = 1;
        person2.FirstName = "James";
        person2.LastName = "Cao";
        person2.Age = 35;


        personList.Add(person1);
        personList.Add(person2);
    }

    public void ApplyForMask(Person person)
    {
        throw new NotImplementedException();
    }

    public List<Person> GetList()
    {
        return personList;
    }
}

