namespace matematica;
public class Calculadora{
    private double dato;
    public double Resultado {get => dato;}
    public void sumar(double termino){
        dato = dato + termino;
    }
    public void restar(double termino){
        dato = dato - termino;
    }
    public void multiplicar(double termino){
        dato = dato * termino;
    }

    public void dividir(double termino){
        dato = dato / termino;
    }

    public void limpiar(){
        dato = 0;
    }
}

public class Operacion{
 private double resultadoAnterior;
 private double nuevoValor;
 private TipoOperacion operacion;
 public double Resultado{
        get
        {
            if (operacion == TipoOperacion.Suma){
                return resultadoAnterior + nuevoValor;
            }
            if (operacion == TipoOperacion.Resta){
                return resultadoAnterior - nuevoValor;
            }
            if (operacion == TipoOperacion.Multiplicacion){
                return resultadoAnterior * nuevoValor;
            }
            if (operacion == TipoOperacion.Division){
                return resultadoAnterior / nuevoValor;
            }
            return 0;
        }
 }
 public double NuevoValor{get { return nuevoValor;}}

 public Operacion(double anterior,double valor,TipoOperacion tipo){resultadoAnterior = anterior; nuevoValor = valor; operacion = tipo;}
}

public enum TipoOperacion{
 Suma,
 Resta,
 Multiplicacion,
 Division,
 Limpiar // Representa la acción de borrar el resultado actual o el historial
 }

