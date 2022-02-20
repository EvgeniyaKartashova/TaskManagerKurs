using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TaskManagerKurs.Api.Models
{
    public class Desk:Abstractions.CommonObject
    {
        public int Id { get; set; }
        public bool IsPrivate { get; set; }
        public string Columns { get; set; }
        public int? AdminId { get; set; }
        public User Admin { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();
    }
}
