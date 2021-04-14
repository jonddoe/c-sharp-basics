using System;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        public Car(double startOdo)
        {
        }

        private int _liters;
        private int _startKilometers;

        public double CalculateConsumption()
        {
            return Convert.ToInt64(_startKilometers / _liters);
        }

        private double ConsumptionPer100Km()
        {
            return 100.0 / (Convert.ToInt64(_startKilometers / _liters));
        }

        public bool GasHog()
        {
            if (ConsumptionPer100Km() > 15)
            {
                return true;
            }

            return false;
        }

        public bool EconomyCar()
        {
            if (ConsumptionPer100Km() < 5)
            {
                return true;
            }

            return false;
        }

        public void FillUp(int mileage, int liters)
        {
            _startKilometers = mileage;
            _liters = liters;
        }
    }
}