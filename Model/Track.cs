using System;
using System.Collections.Generic;

namespace Model
{
    public class Track
    {
        public string name { get; set; }
        public LinkedList<Section> sections { get; set; }
        public Track(string name, SectionTypes[] sections)
        {

        }
    }
}
