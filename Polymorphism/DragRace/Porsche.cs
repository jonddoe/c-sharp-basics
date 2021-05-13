﻿using System;

namespace DragRace
{
    class Porsche : ICar, IBoostable
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 15;
        }

        public void SlowDown()
        {
            _currentSpeed -= 15;
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 25;
        }

        public void StartEngine()
        {
            Console.WriteLine("Brrrrrr.....");
        }
    }
}
