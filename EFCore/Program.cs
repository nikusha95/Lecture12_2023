// See https://aka.ms/new-console-template for more information

using EFCore;
using EFCore.Models;

await using var context = new SchoolDBContext();
context.Students.Add(new Student()
{
    FirstName = "saxeli",
    LastName = "gvari"
});


var teacher = context.Teachers
    .FirstOrDefault(x => x.FullName == "maswavlebeli" || x.FullName == "f1");
teacher.FullName = "Asd";




await context.SaveChangesAsync();
