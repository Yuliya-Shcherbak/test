using System;
using Test.DataAccess.Interfaces;

namespace Test.DataAccess.Entities
{
    public class TaskModel : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ClientModelID { get; set; }
    }
}
