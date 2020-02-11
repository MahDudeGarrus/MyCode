using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarClasses
{

    public enum StarClass
    {
        Mainsequence1 = 1,
        Mainsequence2 =5,
        Mainsequence3 =6,
        Supergiant = 2,
        Giant = 3,
        WhiteDwarf = 4,
        UCMainsequence = 7,


    }
    public class Star
    {
        private string _name;    
        private int _temperature;
        private double _mass;
        private double _absoluteMagnitude;
        private string _distance;
        private string _age;
        private SpectralClass _spectralClass;
        private StarClass _starClass;
        private const double _sunMass = 1;



        /// <summary>
        /// Property -- functions as field, setter funtion, and getter function.
        /// </summary>
        public SpectralClass SpectralClass
        {
            get { return _spectralClass; }
            set { _spectralClass = value; }
        }

        public StarClass StarClass
        {
            get { return _starClass; }
            set { _starClass = value; }
        }


        public string Name { get => _name; set => _name = value; }
        public int Temperature { get => _temperature; set => _temperature = value; }
        public double Mass { get => _mass; set => _mass = value; }
        public double AbsoluteMagnitude { get => _absoluteMagnitude; set => _absoluteMagnitude = value; }
        public string Distance { get => _distance; set => _distance = value; }
        public string Age { get => _age; set => _age = value; }



        /// <summary>
        /// Default constructor, No parameters specified
        /// </summary>
        public Star() { }



        /// <summary>
        /// A simple parametrized constructor
        /// </summary>
        /// <param name="name"></param>
        public Star(string name)
        {
            _name = name;
        }



        /// <summary>
        /// A simple parametrized constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="temp"></param>
        public Star(string name, int temp) 
        {
            _name = name;
            _temperature = temp;
        }


        /// <summary>
        /// A simple parametrized constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="temp"></param>
        /// <param name="mass"></param>
        public Star(string name, int temp, double mass, SpectralClass spectralClass)
        {
            _name = name;
            _temperature = temp;
            _mass = mass;
            _spectralClass = spectralClass;
        }


        /// <summary>
        /// A simple parametrized constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="temp"></param>
        /// <param name="mass"></param>
        /// <param name="absolutem"></param>
        public Star(string name, int temp, double mass, double absolutem)
        {
            _name = name;
            _temperature = temp;
            _mass = mass;
            _absoluteMagnitude = absolutem;
        }


        /// <summary>
        /// A simple parametrized constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="temp"></param>
        /// <param name="mass"></param>
        /// <param name="absolutem"></param>
        /// <param name="distance"></param>
        /// <param name="age"></param>
        public Star(string name, int temp, double mass, double absolutem, string distance)
        {
            _name = name;
            _temperature = temp;
            _mass = mass;
            _absoluteMagnitude = absolutem;
            _distance = distance;
        }


        /// <summary>
        /// A simple parametrized constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="temp"></param>
        /// <param name="mass"></param>
        /// <param name="absolutem"></param>
        /// <param name="distance"></param>
        /// <param name="age"></param>
        public Star(string name, int temp, double mass, double absolutem, string distance, string age)
        {
            _name = name;
            _temperature = temp;
            _mass = mass;
            _absoluteMagnitude = absolutem;
            _distance = distance;
            _age = age;
        }



        /// <summary>
        /// Setter for Temperature
        /// </summary>
        /// <param name="temperature"></param>
        public void SetTemperature(int temperature)
        {
            _temperature = temperature;
        }


        /// <summary>
        /// Getter for Temperature
        /// </summary>
        /// <returns></returns>
        public int GetTemperature()
        {
            return _temperature;
        }

        /// <summary>
        /// Setter for Mass
        /// </summary>
        /// <param name="mass"></param>
        public void SetMass(double mass)
        {
            _mass = mass;
        }


        /// <summary>
        /// Getter for Mass
        /// </summary>
        /// <returns></returns>
        public double GetMass()
        {
            return _mass;
        }


        /// <summary>
        /// Setter for AbsoluteMagnitude
        /// </summary>
        /// <param name="absoluteMagnitude"></param>
        public void SetAbsoluteMagnitude(int absoluteMaginitude)
        {
            _absoluteMagnitude = absoluteMaginitude;
        }


        /// <summary>
        /// Getter for SpectralClass
        /// </summary>
        /// <returns></returns>
        public double GetAbsoluteMagnitude()
        {
            return _absoluteMagnitude;
        }


        /// <summary>
        /// Setter for Distance
        /// </summary>
        /// <param name="distance"></param>
        public void SetDistance(string distance)
        {
            _distance = distance;
        }


        /// <summary>
        /// Getter for SpectralClass
        /// </summary>
        /// <returns></returns>
        public string GetDistance()
        {
            return _distance;
        }


        /// <summary>
        /// Setter for Age
        /// </summary>
        /// <param name="age"></param>
        public void SetAge(string age)
        {
            _age = age;
        }


        /// <summary>
        /// Getter for Age
        /// </summary>
        /// <returns></returns>
        public string GetAge()
        {
            return _age;
        }




        /// <summary>
        /// This public Method to return star's classification
        ///   in a printable version
        /// </summary>
        /// <returns>Star's </returns>
        public string GetStarSpecs()
        {
            var output = "Star Name: " + _name + "Temperature: " + _temperature + "Mass: " + _mass + "Absolute Magnitude: " + _absoluteMagnitude + "Distance from Earth: " + _distance + "Age: " + _age;
            Console.WriteLine(output);
            return output;
        }


        public StarClass GetStarClass()
        {
            if ((_temperature >= 3000 && _temperature <= 15000) && (_absoluteMagnitude <= -3 && _absoluteMagnitude >= -8))
            {
                if (_mass >= 10*_sunMass)
                {
                    _starClass = StarClass.Supergiant;
                    return _starClass;
                }
                   
            }

            if ((_temperature >= 8000 && _temperature <= 30000) && (_absoluteMagnitude >= 10 && _absoluteMagnitude <= 17 ))
            {
                if (_mass < .17 * _sunMass && _mass > 1.33 * _sunMass)
                {
                    _starClass = StarClass.WhiteDwarf;
                    return _starClass;

                }
                    
            }

            if ((_temperature >= 2500 && _temperature <= 5000) && (_absoluteMagnitude < 16 && _absoluteMagnitude > 5))
            {
                if (_mass < _sunMass)
                {
                    _starClass = StarClass.Mainsequence1;
                    return _starClass;

                }

            }

            if ((_temperature >= 2800 && _temperature <= 6000) && (_absoluteMagnitude > -2.5 && _absoluteMagnitude < 2))
            {
                if (_mass > _sunMass)
                    _starClass = StarClass.Giant;
                return _starClass;
            }



            if ((_temperature >=5001 && _temperature <=6000)  && (_absoluteMagnitude < 6 && _absoluteMagnitude >3))
            {
                if (_mass >= _sunMass)
                {
                    _starClass = StarClass.Mainsequence2;
                    return _starClass;

                }
                    
            }

            if ((_temperature >= 6001) && (_absoluteMagnitude < 3 && _absoluteMagnitude >-3))
            {
                if (_mass > _sunMass)
                {
                    _starClass = StarClass.Mainsequence3;
                    return _starClass;

                }
                    
            }


                Console.WriteLine("Unclassified Star Detected");
                _starClass = StarClass.Mainsequence1;
                return _starClass; 


        }
    }
}
