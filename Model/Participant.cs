using System;
using System.Collections.Generic;

namespace Model
{
    public interface Participant
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public Equipment Equipment { get; set; }
        public TeamColor TeamColor { get; set; }
        public List<Participant> Participants { get; set; }
    }
}
