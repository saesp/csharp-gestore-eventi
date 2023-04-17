using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace GestoreEventi
{
    public class EventsPlan
    {
        public string Title {get; set;}
        public List<Event> Events { get; set;}

        public EventsPlan (string title, List<Event> events)
        {
            Title = title;
            Events = new List<Event>();
        }
        
        public void addEvent(Event e)
        {
            Events.Add(e);
        }

        public static void writeEventsList(List<Event> list)
        {
            foreach (var i in list) {
                Console.WriteLine($"{i}");
            }
        }

        public static void countEventsPlan(List<Event> list)
        {
            Console.WriteLine($"Il numero degli eventi dal tuo programma è {list.Count}");
        }

        public static void writeEventsPlan(string title, List<Event> list)
        {
            Console.WriteLine($"Ecco il tuo PROGRAMMA EVENTI: ");

            Console.WriteLine($"{title}");
            foreach (var i in list)
            {
                Console.WriteLine($"{i.Date} - {i.Title}");
            }
        }

        //Clear
        public static void clearEventsList(List<Event> list)
        {
            Console.WriteLine("Elimino eventi dal tuo programma");
            list.Clear();
        }
    }
}