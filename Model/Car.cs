﻿using System;
namespace Model
{
    public class Car : IEquipment
    {
        public Car(int quality, int performance, int speed, bool isBroken)
        {
            quality = Quality;
            performance = Performance;
            speed = Speed;
            isBroken = IsBroken;
        }

        public int Quality { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Performance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsBroken { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
