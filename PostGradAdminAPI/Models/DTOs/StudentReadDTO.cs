﻿using System.ComponentModel.DataAnnotations;

namespace PostGradAdminAPI.Models.DTOs
{
    public class StudentReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ParentName { get; set; }
    }
}
