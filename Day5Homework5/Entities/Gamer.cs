using Day5Homework5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5
{
    public class Gamer: IEntities
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
