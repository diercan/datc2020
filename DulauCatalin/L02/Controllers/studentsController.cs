using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using datc.Models;
namespace datc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        StudentRepo studenti = new StudentRepo();
        
        private readonly ILogger<StudentsController> _logger;
        public StudentsController(ILogger<StudentsController> logger)
        {
            _logger = logger;        
        }
        [HttpGet]
        public List<Student> Get()
        {
            return studenti.stud;
        }
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            foreach (Student student in studenti.stud)
            {
                if(student.id == id)
                {
                    return student;
                }
            }
            return null;
        }
        
        
        [HttpPost]
        
        public List<Student> Post( [FromBody] Student student)
        {
            studenti.stud.Add(student) ;//return pentru testare
            return studenti.stud;
        }
    
       [HttpDelete("{id}")]
       public List<Student> Delete(int id)
        {
           foreach(Student student in studenti.stud)
           {
               if(student.id == id)
               {
                   studenti.stud.Remove(student);
                   return studenti.stud;
               }


           }
           return null;
        }
       [HttpPut("{id}")]
       public Student Update(int id,[FromBody] Student studentUpdate)
       {
           foreach(Student student in studenti.stud)
           {
               if(student.id == id)
               {
                   student.nume=studentUpdate.nume;
                   student.fac=studentUpdate.fac;
                   student.an=studentUpdate.an;
                   return student;
               }
           }
           return null;
           
       }
    }

    
}