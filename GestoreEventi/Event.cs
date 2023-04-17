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
                if (value < DateTime.Now)
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

        public int ReservedSeatsNumber { get; }


        public Event (string title, DateTime date, int seatsNumber)
        {
            Title = title;
            Date = date;
            SeatsNumber = seatsNumber;
        }
    }
}
