using System;

namespace Robotize.DAL.MySql.Models
{
    public class CarEntity
    {
        public string Id { get; set; }
        public string ModelName { get; set; }
        public int CarType { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
