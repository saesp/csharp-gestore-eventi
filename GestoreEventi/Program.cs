using GestoreEventi;
using System.Collections.Generic;
using System.ComponentModel;


//dati nuovo evento
Console.WriteLine("Inserisci un nuovo evento");

Console.Write("Titolo evento: ");
string? titleUser = Console.ReadLine();

Console.Write("Data evento: ");
DateTime dateUser = Convert.ToDateTime(Console.ReadLine());

Console.Write("Numero massimo di posti: ");
int seatsNumberUser = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");

Console.Write($"Quanti posti desideri prenotare? ");
int reservedSeatsNumberUser = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");

//calcolo posti disponibili
int availableSeatsNumber = seatsNumberUser - reservedSeatsNumberUser;

//stampare posti prenotati e disp
Console.WriteLine($"Numero posti prenotati: {reservedSeatsNumberUser}");
Console.WriteLine($"Numero posti ancora disponibili: {availableSeatsNumber} \n");


//ciclo per disdire posti prenotati
int removedSeatsNumberUser = 0;

Console.Write($"Vuoi disdire dei posti per l'evento {titleUser}? (Yes/No) ");
string answerUser = Console.ReadLine();

while (answerUser == "Yes" || answerUser == "yes") {
    Console.Write($"Quanti posti vuoi disdire? ");
    int _removedSeatsNumberUser = Convert.ToInt32(Console.ReadLine());
    Console.Write("\n");

    Console.Write($"Vuoi disdire dei posti per l'evento {titleUser}? (Yes/No) ");
    answerUser = Console.ReadLine();

    removedSeatsNumberUser += _removedSeatsNumberUser; 
}

//se answerUser è no
Console.WriteLine("Va bene!");
Console.Write("\n");

Console.WriteLine($"Numero posti disponibili: {availableSeatsNumber + removedSeatsNumberUser}");
Console.WriteLine($"Numero posti prenotati: {reservedSeatsNumberUser - removedSeatsNumberUser} \n");



//Programma eventi

//lista eventi
List<Event> eventsList = new List<Event>();

//dati programma
Console.Write("Titolo del tuo programma eventi: ");
string titleEventPlanUser = Console.ReadLine();

Console.Write("Quanti eventi vuoi aggiungere al tuo programma? ");
int eventsNumbereUser = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");

//dati eventi
for (int i = 0; i < eventsNumbereUser; i++)
{
    Console.WriteLine($"Inserisci l'evento {i}");

    Console.Write("Titolo evento: ");
    string titleUser_ = Console.ReadLine();

    Console.Write("Data evento (gg/mm/yyyy): ");
    DateTime dateUser_ = Convert.ToDateTime(Console.ReadLine());

    Console.Write("Numero massimo di posti: ");
    int seatsNumberUser_ = Convert.ToInt32(Console.ReadLine());

    Event event_ = new Event(titleUser_, dateUser_, seatsNumberUser_, 0);
    eventsList.Add(event_);
    Console.Write("\n");
}

//numero eventi
EventsPlan.countEventsPlan(eventsList);
Console.Write("\n");

//stampa programma eventi
EventsPlan.writeEventsPlan(titleEventPlanUser, eventsList);
Console.Write("\n");

//elimina eventi
EventsPlan.clearEventsList(eventsList);
Console.Write("\n");