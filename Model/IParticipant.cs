using System;
using System.Collections.Generic;

namespace Model
{
    public interface IParticipant
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public IEquipment Equipment { get; set; }
        public TeamColor TeamColor { get; set; }
    }

}
