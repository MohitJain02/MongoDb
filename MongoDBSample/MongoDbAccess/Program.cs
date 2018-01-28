using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDbAccess
{
   public class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var empDb = client.GetDatabase("Employee");
            var collection = empDb.GetCollection<Employee>("employeeInformation");
            var empId = new ObjectId("5a6dbf91e431a2be34fe8ade");
            var result = collection.Find(x => x.Id == empId).SortBy(y => y.Age).Limit(5).ToListAsync().Result;

            foreach (var emp in result)
            {
                Console.WriteLine($"EmployeeName : { emp.EmployeeName} ");
            }
            ////var document = new Employee()
            ////{
            ////    Age = 12,
            ////    EmployeeName = "mohit",
            ////    EmpId = 3146563
            ////};

            ////collection.InsertOneAsync(document);

            Console.Read();

        }

        public static void GetEmployeeInformation()
        {

        }
    }
}