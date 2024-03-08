using System;
using MaskTrack.Business.Abstract;
using MaskTrack.Entities.Concrete;

namespace MaskTrack.Business.Concrete;

public class PttManager : ISupplierService


{
    private IApplicantService _applicantService;

    public PttManager(IApplicantService applicantService)
    {

        _applicantService = applicantService;
    }

    public void GiveMask(Person person)
    {
        Console.WriteLine(person.FirstName + " took a  face mask");
    }
}

