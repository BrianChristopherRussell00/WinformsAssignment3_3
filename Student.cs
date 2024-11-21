﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsAssignment3_3
{
    public class Student
    {
        public enum MonthofAdmission
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }
        public char Grade { get; set; }

        public MonthofAdmission MonthOfAdmision { get; set; }


        public static void AddStudent(Student student)
        {
            List<Student> Students = new List<Student>();
            if (student != null)
            {

                Students.Add(new Student() { StudentId = 0, FirstName = " ", LastName = " ", Address = " " });
            }
            else
            {
                Console.WriteLine("Cannot add student");


            }


        }
    }
}
