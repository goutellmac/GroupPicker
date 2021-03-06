﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStudents = new List<string>(){"Mac", "Bill", "Jim", "Sally", "Chelsea", "Carla","Bob", "Tim", 
                "Carlos","Aaron", "Dennis", "Linda", "Jehova", "Jesus", "Abel", "Karl", "Abel", "Yoda", "Windu", "Eric"};
            PickGroup(listOfStudents, 3);
            Console.ReadKey();
            
        }

        static void PickGroup(List<string> studentList, int groupSize)
        {
            List<string> currentList = new List<string>();
            int groupNumber = 1;
            Random rng = new Random();
            Console.WriteLine("Roger that.  I'll divide those students into groups of: " + groupSize);
            Console.WriteLine("-----------------");
            Console.WriteLine("-----------------");
        
            while (studentList.Count > 0)
	        {
                string currentStudent = studentList[rng.Next(studentList.Count)];
                currentList.Add(currentStudent);
                studentList.Remove(currentStudent);
                
                //if the currentGroupList size is equal to the groupSize parameter
                if (currentList.Count == groupSize || studentList.Count == 0)
	            {
                    Console.WriteLine("Group " + groupNumber + " includes: ");
                    for (int i = 0; i < currentList.Count; i++)
			        {
			            Console.WriteLine(currentList[i]);
			        }
                    Console.WriteLine("-----------------");
                    Console.WriteLine("-----------------");
                  
                    groupNumber++;
                    currentList.Clear();
	            }

	        }
            

        }
    }
}
