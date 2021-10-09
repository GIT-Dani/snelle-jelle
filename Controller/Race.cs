using System;
using System.Collections.Generic;
using Model;

namespace Controller
{
    public class Race
    {
        private Random _random;
        private Dictionary<Section, SectionData> _positions;
        public Track Track { get; set; }
        public List<IParticipant> Participants { get; set; }
        public DateTime StartTime { get; set; }

        public SectionData GetSectionData(Section section)
        {
            if (_positions.ContainsKey(section))
            {
                return _positions.GetValueOrDefault(section);
            }

            SectionData sectionData = new SectionData();
            _positions.Add(section, sectionData);
            return sectionData;
        }

        public void RandomizeEquipment()
        {
            foreach(IParticipant participant in Participants)
            {
                participant.Equipment.Quality = _random.Next(0, 100);
                participant.Equipment.Performance = _random.Next(0, 100);
            }
        }


        public Race(Track track, List<IParticipant> participants)
        {
            Participants = participants;
            Track = track;
            StartTime = new DateTime();
            _random = new Random(DateTime.Now.Millisecond);
            _positions = new Dictionary<Section, SectionData>();
        }
    }
}
