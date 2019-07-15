using Scholaris.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scholaris.Services
{
    public interface IStudent
    {
        IEnumerable<Student> GetStudents { get; }
        Student GetStudent(int? Id);
        void Add(Student _Student);
        void Remove(int? Id);
    }

}
