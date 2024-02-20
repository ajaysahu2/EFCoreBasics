using EFCoreBasics.Data;
using EFCoreBasics.Models;

var manager = new Manager();
manager.FirstName = "Ajay";
manager.LastName = "Sahu";

using(var context = new AppDbContext()) 
{

}