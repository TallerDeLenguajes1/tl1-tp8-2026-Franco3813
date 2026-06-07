using System.Runtime.InteropServices;

List<Tarea> tareasPendiente = new List<Tarea>();
List<Tarea> tareasRealizada = new List<Tarea>();

Random aux = new Random();
int a = aux.Next(1,11);
Tarea[] tareas = new Tarea[a];
int c = 1000;
string dato;
int id;

for (int i = 0; i < a; i++)
{
    tareas[i] = new Tarea();
    tareas[i].Descripcion = "Descripcion" + i;
    tareas[i].TareaID = c;
    c++;
    tareas[i].Duracion = aux.Next(10, 100);

    tareasPendiente.Add(tareas[i]);
}
Console.WriteLine("Cantidad de Tareas: " +a);

string x;
do
{
    Console.WriteLine("Ingrese una opcion: \n1)Mostrar listas \n2)Mover a tareas realizadas \n3)Buscar por descripcion");
    x = Console.ReadLine();

    if (x == "1")
    {
        mostrarLista(tareasPendiente, "TAREAS PENDIENTES");
        mostrarLista(tareasRealizada, "TAREAS REALIZADAS");
    }
    else if (x == "2")
    {
        Console.WriteLine("Ingrese el id de la tarea pendiente:");
        dato = Console.ReadLine();
        if (int.TryParse(dato, out id))
        {
            Tarea tareaBuscada = tareasPendiente.Where(p => p.TareaID == id).Single();
            tareasPendiente.Remove(tareaBuscada);
            tareasRealizada.Add(tareaBuscada);
        }
    }
    else if (x == "3")
    {
        Console.WriteLine("Ingrese la descripcion de la tarea:");
        dato = Console.ReadLine();
        do{
            if (dato == ""){
                Console.WriteLine("Descripcion invalida por favor ingrese la descripcion de la tarea:");
                dato = Console.ReadLine();
            }
        } while (dato == "");
        Tarea tarea = buscarTareaPorPalabra(tareasPendiente, dato);
        MostrarTarea(tarea);

    }
    Console.WriteLine("Desea Continuar: \n1)No \n2)Si");
    x = Console.ReadLine();
} while (x != "1");



Tarea buscarTareaPorPalabra(List<Tarea> tareas, string dato)
{
    foreach (Tarea tarea in tareasPendiente)
    {
        if (dato.CompareTo(tarea.Descripcion) == 0)
        {
            return tarea;
        }
    }
    return null;
}


void MostrarTarea(Tarea tarea)
{
    Console.WriteLine("Descripcion: "+tarea.Descripcion);
    Console.WriteLine("id: "+tarea.TareaID);
    Console.WriteLine("Duracion: "+tarea.Duracion);
}

void mostrarLista(List<Tarea> tareas, string MensajeCabecera)
{
    Console.WriteLine(MensajeCabecera);
    int s = 1;
    foreach (var tarea in tareas)
    {
        Console.WriteLine("Tarea N°" + s);
        MostrarTarea(tarea);
        s++;
    }
}
