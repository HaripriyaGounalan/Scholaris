using Scholaris.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scholaris.Services
{
    public interface IInstructor
    {
        IEnumerable<Instructor> GetInstructors { get; }
        Instructor GetInstructor(int? Id);
        void Add(Instructor _Instructor);
        void Remove(int? Id);
    }
}
