﻿using System.Text.Json.Serialization;

namespace Hospital_Management.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public ICollection<Doctor> Doctor { get; set; }
    }
}
