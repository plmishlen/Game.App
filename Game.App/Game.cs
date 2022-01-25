using System;
using Microsoft.EntityFrameworkCore;

namespace Game.App
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Creator { get; set; }
        public string Style { get; set; }
        public int Date { get; set; }
    }
}

