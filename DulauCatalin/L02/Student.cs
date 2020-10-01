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
    public class Student{
        public int id { get; set; } 
        public string nume { get; set; } 
        public int an { get; set; } 

        public string fac { get; set; } 

        public Student( int i, string n, int a, string f)
        {
            id = i;
            nume = n;
            an = a;
            fac =f;

        }
    }
}