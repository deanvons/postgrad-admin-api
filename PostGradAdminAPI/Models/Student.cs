using System.ComponentModel.DataAnnotations;

namespace PostGradAdminAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string ParentName { get; set; }

        // not included in ReadDTO
        public string? NickName { get; set; }

    }
}
