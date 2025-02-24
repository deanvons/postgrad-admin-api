using System.Net.Mime;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PostGradAdminAPI.Data;
using PostGradAdminAPI.Models;
using PostGradAdminAPI.Exceptions;

namespace PostGradAdminAPI.Services
{
    public class StudentService
    {
        PostGradDbContext _dbcontext;
        public StudentService(PostGradDbContext dbcontext) { 
        
            _dbcontext = dbcontext;
        }
        //Mock
        public IEnumerable<Student> GetAllStudents()
        {
          

            return  _dbcontext.Students.ToList();


        }


        public Student CreateStudent(Student student)
        {
            _dbcontext.Add(student);
           
            _dbcontext.SaveChanges();

            return student;
        }


        public void Delete(int studentId)
        {
            var studentToDelete = _dbcontext.Students.Find(studentId);

            _dbcontext.Students.Remove(studentToDelete);

            _dbcontext.SaveChanges();

        }

        public Student GetById(int studentId)
        {
            var student = _dbcontext.Students.Find(studentId);

            if(student == null)
            {
                throw new EntityNotFoundException("Student",studentId);
            }

            return student;

        }

        public void ReplaceStudent(int id, Student student)
        {

            

            _dbcontext.Students.Update(student);

            _dbcontext.SaveChanges();

        }
    }
}
