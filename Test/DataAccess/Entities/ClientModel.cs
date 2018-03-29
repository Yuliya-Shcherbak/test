using System.Collections.Generic;
using Test.DataAccess.Interfaces;

namespace Test.DataAccess.Entities
{
    public class ClientModel : IEntity
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<TaskModel> Tasks { get; set; }
    }
}
