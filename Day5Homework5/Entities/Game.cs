using Day5Homework5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5
{
    public class Game: IEntities
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string ReleaseYear { get; set; }
    }
}
