List<Tarea> tareasPendiente = new List<Tarea>();
List<Tarea> tareasRealizada = new List<Tarea>();

Random aux = new Random();
int a = aux.Next(10);
Tarea[] tareas = new Tarea[a];
int c = 1000;
string dato;
int id;
void buscarPorPalabra(string dato){
    foreach (Tarea tarea in tareasPendiente){
        if (dato.CompareTo(tarea.Descripcion) ==  0){
            Console.WriteLine("------Tareas Pendientes------");
            Console.WriteLine("Descripcion: "+tarea.Descripcion);
            Console.WriteLine("id: "+tarea.TareaID);
            Console.WriteLine("Duracion: "+tarea.Duracion);
        }
    }
    
    foreach (Tarea tarea in tareasRealizada){
        if (dato.CompareTo(tarea.Descripcion) ==  0){
            Console.WriteLine("------Tareas Realizada------");
            Console.WriteLine("Descripcion: "+tarea.Descripcion);
            Console.WriteLine("id: "+tarea.TareaID);
            Console.WriteLine("Duracion: "+tarea.Duracion);
        }
    }
}

void mostrarLista(){
    Console.WriteLine("------Tareas Pendientes------");
    int s =1;
    foreach (var tarea in tareasPendiente){
        Console.WriteLine("Tarea N°"+s);
        Console.WriteLine("Descripcion: "+tarea.Descripcion);
        Console.WriteLine("id: "+tarea.TareaID);
        Console.WriteLine("Duracion: "+tarea.Duracion);
        s++;
    }

    s =1;

    Console.WriteLine("------Tareas Realizadas------");
    foreach (var tarea in tareasRealizada){
        Console.WriteLine("Tarea N°"+s);
        Console.WriteLine("Descripcion: "+tarea.Descripcion);
        Console.WriteLine("id: "+tarea.TareaID);
        Console.WriteLine("Duracion: "+tarea.Duracion);
        s++;
    }
}


for (int i = 0; i < a; i++){
    tareas[i] = new Tarea();
    tareas[i].Descripcion = "Descripcion"+i;
    tareas[i].TareaID = c;
    c++;
    tareas[i].Duracion = aux.Next(10,100);

    tareasPendiente.Add(tareas[i]);
}
Console.WriteLine("Cantidad de Tareas: "+(a+1));

string x;
do{
    Console.WriteLine("Ingrese una opcion: \n1)Mostrar listas \n2)Mover a tareas realizadas \n3)Buscar por descripcion");
    x = Console.ReadLine();

    if (x == "1"){
        mostrarLista();
    }else if(x == "2"){
        Console.WriteLine("Ingrese el id de la tarea pendiente:");
        dato = Console.ReadLine();
        int.TryParse(dato, out id);
        tareasRealizada.Add(tareasPendiente[id-1000]);
        tareasPendiente.RemoveAt(id-1000);
    }else if (x == "3"){
        Console.WriteLine("Ingrese la descripcion de la tarea:");
        dato = Console.ReadLine();
        buscarPorPalabra(dato);
    }
    Console.WriteLine("Desea Continuar: \n1)No \n2)Si");
    x = Console.ReadLine();
} while (x != "1");