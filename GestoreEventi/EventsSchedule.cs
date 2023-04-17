using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//Creare una classe ProgrammaEventi con i seguenti attributi
//●	string Titolo
//●	List<Evento> eventi

//Nel costruttore valorizzare il titolo, passato come parametro, e inizializzate la lista di eventi come una nuova Lista vuota di eventi.

//Aggiungete poi i seguenti metodi:
//●	un metodo che aggiunge alla lista del programma eventi un Evento, passato come parametro al metodo.
//●	un metodo che restituisce una lista di eventi con tutti gli eventi presenti in una certa data.
//●	un metodo statico che si occupa, presa una lista di eventi, di stamparla in Console, o ancora meglio vi restituisca la rappresentazione in stringa della vostra lista di eventi.


//●	un metodo che restituisce quanti eventi sono presenti nel programma eventi attualmente.

//●	un metodo che svuota la lista di eventi.

//●	un metodo che restituisce una stringa che mostra il titolo del programma e tutti gli eventi aggiunti alla lista. Come nell’esempio qui sotto:
//Nome programma evento:
//data1 - titolo1
//data2 - titolo2
//data3 - titolo3


namespace GestoreEventi
{
    internal class EventsSchedule
    {
        public string Title {get; set;}
        public List<Event> Events { get; set;}

        public EventsSchedule (string title, List<Event> events)
        {
            Title = title;
            Events = new List<Event>();
        }
        
        public void addEvent(Event e)
        {
            Events.Add(e);
        }

        public static void writeEventList(List<Event> list)
        {
            foreach(var i in list) {
                Console.WriteLine($"{i}");
            }
        }

        public void countEventSchedule()
        {
            Console.WriteLine($"{Events.Count}");
        }
        public void clearEventList()
        {
            Events.Clear();
        }

        public void writeEventSchedule(List<Event> list)
        {
            Console.WriteLine($"{Title}");

            foreach (var i in list)
            {
                Console.WriteLine($"{i.Date} - {i.Title}");
            }
        }
    }
}
