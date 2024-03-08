using System;
using MaskTrack.Entities.Concrete;

namespace MaskTrack.Business.Abstract;

public interface IApplicantService

{

    public void ApplyForMask(Person person);

    public List<Person> GetList();


}

