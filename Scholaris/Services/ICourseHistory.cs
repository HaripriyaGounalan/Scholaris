using Scholaris.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scholaris.Services
{
    interface ICourseHistory
    {
        IEnumerable<CourseHistory> GetCourseHistorys { get; }
        CourseHistory GetCourseHistory(int? Id);
        void Add(CourseHistory _CourseHistory);
        void Remove(int? Id);
    }
}
