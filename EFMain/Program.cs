using DAL.Models;
using System;
using System.Collections.Generic;
using DAL;

namespace EFMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new SchoolContext();

            var exist = context.Database.EnsureCreated();
            context.SaveChanges();
        }

    }
}
