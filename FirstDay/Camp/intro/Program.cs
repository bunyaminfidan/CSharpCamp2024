
using intro.Business;
using intro.DataAccess.Concretes;
using intro.Entities;


 CourseManager courseManager = new( new DapperCourseDal());

List<Course> courses = courseManager.GetAll();

foreach (var course in courses)
{
    Console.WriteLine(course.Id);
    Console.WriteLine(course.Name);
    Console.WriteLine(course.Description);
    Console.WriteLine(course.Price);
    Console.WriteLine("--------/---------");
}





IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.FirstName = "Ben";
customer1.LastName = "Co";
customer1.CustomerNumber = "12345";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.FirstName = "Atilla";
customer2.LastName = "Ozgur";
customer2.CustomerNumber = "12345678";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "KodlamaIO";
customer3.CustomerNumber = "232323";
customer3.TaxNumber = "1234567890";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 3;
customer4.Name = "Abc Company";
customer4.CustomerNumber = "333";
customer4.TaxNumber = "1234567897";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//Polymorphism
foreach (var customer in customers)
{
   // Console.WriteLine(customer.CustomerNumber);
}


