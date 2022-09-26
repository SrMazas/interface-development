﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_03_04_exercise
{
    internal class PeopleManager
    {

        public List<Person> people = new List<Person>();

        public int Position(int age)
        {

            for (int i = 0; i < people.Count; i++)
            {
                if (age > people[i].Age)
                {
                    return i+1;
                }
            }

            return 0;
        }

        public int Position(string surname)
        {

            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Surname.StartsWith(surname))
                {
                    return i+1;
                }
            }

            return -1;
        }

        bool Delete(int max,int min= 0)
        {
            try
            {
                people.RemoveRange(min, min - max);

            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
            
        }
    }

}
