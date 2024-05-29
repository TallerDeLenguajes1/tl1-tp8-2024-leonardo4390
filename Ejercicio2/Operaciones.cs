using System;

enum TipoOperacion
{
    Suma,
    Resta,
    Multiplicacion,
    Division,
    Limpiar
}
class Operaciones
{
    public double resultadoAnterior{get;set;}
    public double nuevoValor{get;set;}
    public TipoOperacion operacion{get;set;}
    
}
    