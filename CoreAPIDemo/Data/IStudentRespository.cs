using CoreAPIDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPIDemo
{
    public interface IStudentRespository
    {
        ActionResult<IEnumerable<Student>> Get();

        void Post(Student student);

        void Update(Student student);

        void Delete(int? id);
    }
}
