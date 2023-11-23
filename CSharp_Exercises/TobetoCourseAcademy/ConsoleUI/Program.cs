using Business.Concretes;
using Core.Utilities.Results;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Query;
using System.ComponentModel;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseManager = new CourseManager(new EfCourseDal());
            var result = courseManager.GetAll();

            if (result.IsSuccess)
            {
                foreach (var course in result.Data)
                {
                    Console.WriteLine(course.Name);
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}