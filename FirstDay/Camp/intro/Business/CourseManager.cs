using System;
using intro.DataAccess.Abstracts;
using intro.DataAccess.Concretes;
using intro.Entities;

namespace intro.Business;

public class CourseManager

{
   private readonly ICourseDal _courseDal;

 

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {

      

        return _courseDal.GetAll();
    }


}

