﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenCSharpCodingSamples
{
    public class ClassExamples1
    {
        public class Motor
        {
            public int m_nPowerBHP;
            public int m_nPowerKW;
            public int m_nCylinders;

            public void UpdateCylinders(int nCylinders, ref int nPowerBHP, ref int nPowerKW)
            {
                m_nCylinders = nCylinders;
                nPowerBHP= m_nPowerBHP;
                nPowerKW = m_nPowerKW;
            }
            public void UpdatePowerBHP(int nPowerBHP, out int nPowerKW)
            {
                nPowerKW = 0;
                if (nPowerBHP != 0)
                {
                    m_nPowerBHP = nPowerBHP;
                    nPowerKW = m_nPowerBHP / 2;
                }
            }
            public void UpdatePowerKW(int nPowerKW, out int nPowerBHP)
            {
                nPowerBHP = 0;
                if (nPowerKW != 0)
                {
                    m_nPowerKW = nPowerKW;
                    nPowerBHP = m_nPowerKW * 2;
                }
            }
        }

        public class Vehicle
        {
            public Vehicle()
            {
                Vehicle.m_nVehicles++;
                m_Motor = new Motor();
            }

            public string m_Name;
            public string m_Manufacturer;
            public int m_nDoors;
            public int m_nWheels;
            public string m_BaseColour;
            public string m_SecondaryColour;
            public static int m_nVehicles;

            // Instance method is per-object
            public void DisplayDetails()
            {
                StringBuilder sb= new StringBuilder();
                sb.Append("Name=" + m_Name + "; ");
                sb.Append("Manufacturer=" + m_Manufacturer + "; ");
                sb.Append("Doors=" + m_nDoors + "; ");
                sb.Append("Wheels=" + m_nWheels + "; ");
                if (m_BaseColour != null && m_BaseColour.Length > 0)
                    sb.Append("BaseColour=" + m_BaseColour + "; ");
                if (m_SecondaryColour != null && m_SecondaryColour.Length > 0)
                    sb.Append("SecondaryColour=" + m_SecondaryColour + "; ");
                Console.WriteLine(sb.ToString());
            }


            public Motor m_Motor;
        }

        public class Bike : Vehicle
        {
            public static int m_nBikes;
            public Bike()
            {
                Bike.m_nBikes++;
                //m_nDoors = 0;
                m_nWheels = 2;
            }

            // Default arguments have to be done via func overrides...
            public void Colour(string BaseColour)
            {
                this.Colour(BaseColour, "");
            }
            public void Colour(string BaseColour, string SecondaryColour)
            {
                m_BaseColour= BaseColour;
                m_SecondaryColour= SecondaryColour;
            }

            public readonly string m_TaxationClass = "BikeTax";
        }

        public class Car : Vehicle
        {
            public static int m_nCars;
            public Car()
            {
                Car.m_nCars++;
                m_nWheels = 4;
            }

            public readonly string m_TaxationClass = "CarTax";

            // Static method is like a global class func
            public static void DisplayStaticDetails()
            {
                Console.WriteLine("; #Cars=" + m_nCars);
            }
        }


        public static void ClassExamples1Func()
        {
            Car car1 = new Car();
            car1.m_Name = "MX5";
            car1.m_nDoors = 2;
            car1.m_Motor.m_nPowerBHP = 140;

            Car car2 = new Car();
            car2.m_Name = "9-3";
            car2.m_Manufacturer = "Saab";
            car2.m_nDoors = 4;
            car2.m_Motor.m_nPowerBHP = 150;

            Bike bike = new Bike();
            bike.m_Name = "GSX-R750";
            bike.m_Manufacturer = "Suzuki";
            bike.m_Motor.m_nPowerBHP = 120;

            car1.DisplayDetails();
            car2.DisplayDetails();

            Car.DisplayStaticDetails();

            // Default arguments...
            bike.Colour("Red");
            bike.Colour("White", "Blue");
            bike.DisplayDetails();

            // Out parameters...
            int nKW;
            bike.m_Motor.UpdatePowerBHP(160, out nKW);
            
            // ref parameters...
            int nBHP=0;
            nKW=0;
            bike.m_Motor.UpdateCylinders(4, ref nBHP, ref nKW);
        }
    }
}