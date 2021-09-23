using System;
namespace Model
{
    public class SectionData
    {
        public Participant Left { get; set; }
        public int DistanceLeft { get; set; }
        public Participant Right { get; set; }
        public int DistanceRight { get; set; }
        public SectionData()
        {
        }
    }
}
