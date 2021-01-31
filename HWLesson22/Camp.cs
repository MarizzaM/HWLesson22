using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson22
{
    class Camp
    {
        private readonly int id;
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public int NumberOfPeople { get; private set; }
        public int NumberOfTents { get; private set; }
        public int NumberOfFleshLights { get; private set; }
        private static int lastCampId = 0;

        public Camp(double latitude, double longitude, int numberOfPeople, int numberOfTents, int numberOfFleshLigts)
        {
            Latitude = latitude;
            Longitude = longitude;
            NumberOfPeople = numberOfPeople;
            NumberOfTents = numberOfTents;
            NumberOfFleshLights = numberOfFleshLigts;
            id = ++lastCampId;
        }

        public override string ToString()
        {
            return $"\nLatitude: {Latitude};  Longitude: {Longitude} \n Number of people: {NumberOfPeople} " +
                $"\nNumber of tents: {NumberOfTents} \nNumber of flesh lights: {NumberOfFleshLights}";
        }

        public static bool operator ==(Camp c1, Camp c2)
        {
            if (ReferenceEquals(c1, null) && ReferenceEquals(c2, null))
            {
                return true;
            }

            if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null))
            {
                return false;
            }

            if (c1.id == c2.id)
                return true;

            return false;
        }

        public static bool operator !=(Camp c1, Camp c2)
        {
            return !(c1 == c2);
        }

        public static bool operator >(Camp c1, Camp c2)
        {
            if (c1 == c2)
                return false;

            return (c1.NumberOfPeople >c2.NumberOfPeople);
        }

        public static bool operator <(Camp c1, Camp c2)
        {
            if (c1 == c2)
                return false;

            return !(c1 > c2);
        }

        public override bool Equals(object obj)
        {
            var camp = obj as Camp;
            if (ReferenceEquals(obj, null))
                return false;

            return this.id == camp.id;
        }

        public override int GetHashCode()
        {
            return this.id;
        }

        public static Camp operator +(Camp c1, Camp c2)
        {
            return new Camp (c1.Latitude + c2.Latitude, c1.Longitude + c2.Longitude, c1.NumberOfPeople + c2.NumberOfPeople, 
                c1.NumberOfTents + c2.NumberOfTents, c1.NumberOfFleshLights + c2.NumberOfFleshLights);
        }

    }
}
