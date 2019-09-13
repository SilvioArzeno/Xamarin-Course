using LoginPractice.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoginPractice.Services
{
    interface INewbeeAPI
    {
        [Get("/student")]
        Task<List<Student>> GetAllStudents();

        [Get("/student/{matricula}")]
        Task<Student> GetStudent(string matricula);

    }
}
