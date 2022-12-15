using System;
using System.Collections.Generic;

namespace SPR_NotIdealCode
{
    public class Database
    {
        public void Connect()
        {
            Console.WriteLine("Connection is ready with Database");
        }

        public void Disconnect()
        {
            Console.WriteLine("Connection is disconnected with Database");
        }

        public string State { get; set; }

        //GetPerson его место не здесь
        public List<Person> GetPerson()
        {
            return new()
            {
                new(){Name = "Melis", Surname = "Archabaev"},
                new(){Name = "Aibek", Surname = "Karymbekov"},
                new(){Name = "Alymbek", Surname = "Adashov"},
                new(){Name = "Askat", Surname = "Bekboev"},
            };
        }
    }
}