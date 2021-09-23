using System;
using System.Collections.Generic;

namespace Model
{
    public class Competition
    {
        public List<Participant> Participants { get; set; }
        public Queue<Track> Tracks { get; set; }
        public Competition()
        {

        }
    }
}
