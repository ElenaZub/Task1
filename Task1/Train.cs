using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public struct Train
    {
        public string Appointment { get; }

        public int Number { get; }

        public DateTime Time { get; }

        public Train(string appointment, int number, DateTime time)
        {
            if (number == 0)
                throw new ArgumentException(nameof(number));

            if (string.IsNullOrWhiteSpace(appointment))
                throw new ArgumentException(nameof(appointment));

            this.Appointment = appointment;
            this.Number = number;
            this.Time = time;
        }
    }
}
