using Model;
using System;

namespace Controller
{
    public static class Data
    {
        public static Competition Competition { get; private set; }

        public static void Initialize()
        {
            Competition = new Competition();
            AddParticipants();
        }

        public static void AddParticipants()
        {
            Competition.Participants.Add(new Driver("Dani", 100, new Car(69, 69, 69, false), TeamColor.Red));
            Competition.Participants.Add(new Driver("Gework", 99, new Car(69, 69, 69, false), TeamColor.Red));
            Competition.Participants.Add(new Driver("Florian", 98, new Car(69, 69, 69, false), TeamColor.Red));
            Competition.Participants.Add(new Driver("Daape", 420, new Car(69, 69, 69, false), TeamColor.Red));
        }

        public static void AddTracks()
        {
            Competition.Tracks.Enqueue(new Track("Qatar", new SectionTypes[]
            {
                SectionTypes.StartGrid,
                SectionTypes.StartGrid,
                SectionTypes.Straight,
                SectionTypes.Straight,
                SectionTypes.RightCorner,
                SectionTypes.Straight,
                SectionTypes.LeftCorner,
                SectionTypes.Straight,
                SectionTypes.RightCorner,
                SectionTypes.RightCorner,
                SectionTypes.Straight,
                SectionTypes.Straight,
                SectionTypes.Straight,
                SectionTypes.RightCorner,
                SectionTypes.RightCorner,
                SectionTypes.Straight,
                SectionTypes.Finish
            }));
            Competition.Tracks.Enqueue(new Track("Olst", new SectionTypes[]
            {
                SectionTypes.StartGrid,
                SectionTypes.StartGrid,
                SectionTypes.Straight,
                SectionTypes.Straight,
                SectionTypes.LeftCorner,
                SectionTypes.Straight,
                SectionTypes.RightCorner,
                SectionTypes.Straight,
                SectionTypes.LeftCorner,
                SectionTypes.LeftCorner,
                SectionTypes.Straight,
                SectionTypes.Straight,
                SectionTypes.Straight,
                SectionTypes.LeftCorner,
                SectionTypes.LeftCorner,
                SectionTypes.Straight,
                SectionTypes.Finish
            }));


        }
    }
}
