using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestoreEventi
{
    public class Event
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                if (value == null || value.Length == 0)
                    Console.WriteLine("Il titolo non contiene nulla");
                else
                    _title = value;
            }
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (value > DateTime.Now)
                    _date = value;
                else
                    Console.WriteLine("La data inserita non è valida");
            }
        }

        private int _seatsNumber;
        public int SeatsNumber {
            get { return _seatsNumber; }
            set {
                if (value > 0)
                    _seatsNumber = value;
                else
                    Console.WriteLine("Il numero di posti non è valido");
            }
        }

        public int ReservedSeatsNumber { get; set; }

        public Event (string title, DateTime date, int seatsNumber)
        {
            Title = title;
            Date = date;
            SeatsNumber = seatsNumber;
            ReservedSeatsNumber = 0; 
        }
        
        public void AddReservedSeats(int value)
        {
            int availableSeats = SeatsNumber - ReservedSeatsNumber; 
            if (Date > DateTime.Now && value <= availableSeats)
                ReservedSeatsNumber = value + ReservedSeatsNumber;
            else
                Console.WriteLine("Il numero non è valido");
        }

        public void RemoveReservedSeats(int value)
        {
            if (Date > DateTime.Now && value <= ReservedSeatsNumber)
                //ReservedSeatsNumber = value - ReservedSeatsNumber;
                ReservedSeatsNumber -= value;
            else
                Console.WriteLine("Il numero non è valido");
        }

        public override string ToString()
        {
            var text = $"{Date.ToString("dd/MM/yyyy")} - {Title}";

            return text; 
        }
    }
}
