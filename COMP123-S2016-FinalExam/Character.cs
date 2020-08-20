using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// FILE NAME : Character.cs
/// AUTHOR'S NAME : NURLYBEK SULTAMURATOV
/// STUDENT NUMBER : 301103746
/// CHANGES MADE : CREATED PUBLIC PROPERTIES FOR FIRSTNAME AND LASTNAME
/// </summary>
namespace COMP123_M2020_FinalExam
{
    public class Character
    {
        //PUBLIC PROPERTIES//
        /// <summary>
        /// GETS VALUES FROM GENERATION 
        /// </summary>
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Strength { get; set; }

        public string Dexterity { get; set; }

        public string Constitution { get; set; }

        public string Intelligence { get; set; }

        public string Wisdom { get; set; }

        public string Charisma { get; set; }

        public string Race { get; set; }
    }
}