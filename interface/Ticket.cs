using System;

namespace Interface
{
    class Ticket: IEquatable<Ticket>{
        public int DurationInHour{get;set;}
        public Ticket(int durationInHour){
            DurationInHour=durationInHour;
        }

        public bool Equals(Ticket other){
            return this.DurationInHour=other.DurationInHour;
        }
    }
}