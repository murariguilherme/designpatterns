using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public bool Active { get; set; }

        public Student()
        {
            Id = Guid.NewGuid();
            IncludeDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Id: {this.Id}, Name: {this.Name}, Gender: {this.Gender}, " +
                $"Active: {this.Active.ToString()}.";
        }
    }

    public enum Gender
    {
        Male = 0,
        Female = 1
    }
}
