using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace datc
{
    public class StudentRepo{
     public List<Student> stud;
     public StudentRepo(){
         stud = new List<Student>();
        Student st = new Student(1,"mihai",3,"ac");
        stud.Add(st);
        st = new Student(2,"mih",3,"ah");
        stud.Add(st);
        st = new Student(3,"mai",3,"jui");
        stud.Add(st);
        st = new Student(4,"mihi",3,"yju");
        stud.Add(st);
     }
    
    }
}