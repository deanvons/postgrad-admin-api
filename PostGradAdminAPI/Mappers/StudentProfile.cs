using AutoMapper;
using PostGradAdminAPI.Models;
using PostGradAdminAPI.Models.DTOs;

namespace PostGradAdminAPI.Mappers
{
    public class StudentProfile : Profile
    {
        public StudentProfile() { 
        
        
        CreateMap<Student,StudentReadDTO>().ReverseMap();
        
        
        
        
        
        } 





    }
}
