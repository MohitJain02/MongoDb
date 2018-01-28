using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbAccess
{
   public class Employee
    {
        public ObjectId Id { get; set; }
        public string EmployeeName { get; set; }

        public int EmpId { get; set; }

        public int Age { get; set; }
    }
}
