using GestoreEventi;
using System.ComponentModel;


Console.WriteLine("Inserisci un nuovo evento");

Console.Write("Titolo evento: ");
string? titleUser = Console.ReadLine();

Console.Write("Data evento: ");
DateTime dateUser = Convert.ToDateTime(Console.ReadLine());

Console.Write("Numero massimo di posti: ");
int seatsNumberUser = Convert.ToInt32(Console.ReadLine());

Console.Write("\n");


Console.Write($"Per l'evento {titleUser} quanti posti vuoi prenotare? ");
int reservedSeatsNumberUser = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");


List<Event> eventList = new List<Event>();
Event event1 = new Event(titleUser, dateUser, seatsNumberUser, reservedSeatsNumberUser);
eventList.Add(event1);


int availableSeatsNumber = seatsNumberUser - reservedSeatsNumberUser; 

Console.WriteLine($"Numero posti prenotati: {reservedSeatsNumberUser}");
Console.WriteLine($"Numero posti ancora disponibili: {availableSeatsNumber} \n");


Console.Write($"Per l'evento {titleUser} quanti posti vuoi disdire? ");
int removedSeatsNumberUser = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");


Console.WriteLine($"Numero posti disponibili: {availableSeatsNumber + removedSeatsNumberUser}");
Console.WriteLine($"Numero posti prenotati: {reservedSeatsNumberUser - removedSeatsNumberUser} \n");

