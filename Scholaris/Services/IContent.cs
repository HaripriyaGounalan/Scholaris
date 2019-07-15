using Scholaris.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scholaris.Services
{
    interface IContent
    {
        IEnumerable<Content> GetContents { get; }
        Content GetContent(int? Id);
        void Add(Content _Content);
        void Remove(int? Id);
    }
}
