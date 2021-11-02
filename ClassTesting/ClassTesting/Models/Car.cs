using System;
namespace ClassTesting.Models
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        private double _consuption;
        public double Consuption {
            get
            {
                return _consuption;
            }
            private set
            {
                if (value > 0 && value < 300)
                {
                    _consuption = value;
                }
            }
        }

        private double _tankCapacity;
        public double TankCapacity
        {
            private set
            {
                if (value > 0)
                {
                    _tankCapacity = value;
                }
            }
            get
            {
                return _tankCapacity;
            }
        }

        private double _currentTankCap;
        public double CurrentTankCap
        {
            get
            {
                return _currentTankCap;
            }
            private set
            {
                if (value > 0)
                {
                    //_currentTankCap = value;
                    if (_tankCapacity - _currentTankCap > value)
                    {
                        _currentTankCap = _tankCapacity;
                    }
                    else
                    {
                        _currentTankCap = value;
                    }
                }
            }
        }


        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public Car(double consuption, double tankCapacity)
        {
            Consuption = consuption;
            TankCapacity = tankCapacity;
            CurrentTankCap = TankCapacity;
        }

        public string Refuel(double bensin)
        {
            CurrentTankCap += bensin;
            return $"Your current tank is {CurrentTankCap}";
        }
        public string Refuel()
        {
            CurrentTankCap = TankCapacity;
            return $"Your current tank is {CurrentTankCap}";

        }

        public string Drive(double distance)
        {
            double currentCons = distance * (Consuption / 100);
            if (currentCons < CurrentTankCap)
            {
                CurrentTankCap -= currentCons;
                return $"Your car gone so far and your current gas is {CurrentTankCap}";
            }
            else
            {
                return "You cannot go this far";
            }
        }

        public override string ToString()
        {
            return $"Your current Tank is {CurrentTankCap}";
        }
    }
}
