using matematica;

Calculadora miCalculadora = new Calculadora();
miCalculadora.limpiar();
List<Operacion> historial = new List<Operacion>();
string continuar;
double num1;

Console.WriteLine("------Calculadora------");
do{
    Console.WriteLine("Numero anterior: "+miCalculadora.Resultado);
    Console.WriteLine("Ingrese una operacion \n1)sumar \n2)restar \n3)multiplicar \n4)dividir \n5)limpiar");
    string c = Console.ReadLine();

    if (c == "1"){
        num1 = conversion();
        double anterior = miCalculadora.Resultado;
        miCalculadora.sumar(num1);
        Operacion op = new Operacion(anterior, num1, TipoOperacion.Suma);
        historial.Add(op);
    }
    if (c == "2"){
        num1 = conversion();
        miCalculadora.restar(num1);
        double anterior = miCalculadora.Resultado;
        Operacion op = new Operacion(anterior, num1, TipoOperacion.Resta);
        historial.Add(op);
    }
    if (c == "3"){
        num1 = conversion();
        double anterior = miCalculadora.Resultado;
        miCalculadora.multiplicar(num1); 
        Operacion op = new Operacion(anterior, num1, TipoOperacion.Multiplicacion);
        historial.Add(op);   
    }
    if (c == "4"){
        num1 = conversion();
        double anterior = miCalculadora.Resultado;
        miCalculadora.dividir(num1);
        Operacion op = new Operacion(anterior, num1, TipoOperacion.Division);
        historial.Add(op);    
    }
    if (c == "5"){
        miCalculadora.limpiar();    
    }

    Console.WriteLine("Resultado: "+miCalculadora.Resultado);

    Console.WriteLine("Historial de Resultados");
    foreach (var a in historial){    
        Console.WriteLine(a.Resultado);
    }

    Console.WriteLine("Desea continuar? \n1)no \n2)si");
    continuar = Console.ReadLine();
} while (continuar == "2");

double conversion(){
    Console.WriteLine("Ingrese un numero: ");
    string num = Console.ReadLine();
    double.TryParse(num, out num1);
    return num1;
}
