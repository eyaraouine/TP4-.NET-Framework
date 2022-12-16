using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TP4_ASP.NET.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name  { get; set; }
        public string Phone_Number { get; set; }
        public string University { get; set; }
        public string Timestamp { get; set; }
        public string Course { get; set; }
        public Student() { }

        public Student(int id, string first_name, string last_name, string phone_number, string university, string timestamp, string course)
        {
            this.Id = id;
            this.First_Name = first_name;
            this.Last_Name = last_name;
            this.Phone_Number = phone_number;
            this.University = university;
            this.Timestamp = timestamp;
            this.Course = course;
        }

    }
}
