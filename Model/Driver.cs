using System;
namespace Model
{
    public class Driver : IParticipant
    {
        public Driver(string name, int points, IEquipment equipment, TeamColor teamColor)
        {
            name = Name;
            points = Points;
            equipment = Equipment;
            teamColor = TeamColor;
        }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Points { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEquipment Equipment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TeamColor TeamColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
