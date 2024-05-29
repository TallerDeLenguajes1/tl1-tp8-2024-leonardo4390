using System;
using System.Collections.Generic;
class Calculadora{
    //private double numero1,numero2;

    List<Operaciones> operaciones =new List<Operaciones>();

    public void Resultado(){
        int opcion = -1;
        double anterior = 0,anterior2=0,anterior3=0,anterior4=0;
        while (opcion !=0)
        {
            Console.WriteLine("\n***MENU***\n");
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicacion");
            Console.WriteLine("4 - Division");
            Console.WriteLine("0 - Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 0)
            {
                Console.WriteLine();
                break;
            }
            Console.WriteLine("Ingrese un numero");
            double numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            
            switch (opcion)
            {
                case 1: double suma = numero + numero2;
                        
                        Console.WriteLine("\nSuma: " + suma);
                        Operaciones operacionSuma = new Operaciones{resultadoAnterior=anterior, nuevoValor = suma,operacion=TipoOperacion.Suma};
                        operaciones.Add(operacionSuma);
                        anterior = suma;
                    break;
                case 2: double resta = numero - numero2;
                        Console.WriteLine("\nResta: " + resta);
                        Operaciones operacionResta = new Operaciones{resultadoAnterior=anterior2, nuevoValor = resta,operacion=TipoOperacion.Resta};
                        operaciones.Add(operacionResta);
                        anterior2 = resta;
                        
                    break;
                case 3: double multiplicacion = numero * numero2;
                        Console.WriteLine("\nMultiplicacion: " + multiplicacion);
                        Operaciones operacionMultiplicar = new Operaciones{resultadoAnterior=anterior3, nuevoValor = multiplicacion,operacion=TipoOperacion.Multiplicacion};
                        operaciones.Add(operacionMultiplicar);
                        anterior3 = multiplicacion;
                        
                    break;
                case 4: double division = numero / numero2;
                        Console.WriteLine("\nDivision: " + division);
                        Operaciones operacionDivision = new Operaciones{resultadoAnterior=anterior4, nuevoValor = division,operacion=TipoOperacion.Division};
                        operaciones.Add(operacionDivision);
                        anterior4 = division;
                        
                    break;
                default:Console.WriteLine("\nOpcion incorrecata");
                    break;
            }
            

           

        }
        while(true)
        {
            Console.WriteLine("\nDesea ver el historial de calculos realizados? (s para si)");
            var historial = Console.ReadLine().ToLower();
            if (historial != "s")
            {
                break;
            }
            else{
                Console.WriteLine("\nIngrese operacion (Suma/Resta/Multiplicacion/Division/Limpiar)");
                TipoOperacion operacion2 = (TipoOperacion)Enum.Parse(typeof(TipoOperacion),Console.ReadLine(),true);
                if (operaciones.Count > 0)
                {
                    foreach (var item in operaciones)
                    {
                        if (item.operacion == operacion2)                    
                        {
                            if (operacion2 != TipoOperacion.Limpiar)
                            {
                                Console.WriteLine($"\n{item.operacion} => Anterior: {item.resultadoAnterior} Actual Valor: {item.nuevoValor}");    
                            }else{
                                operaciones.Clear();
                                Console.WriteLine("\nhistorial borrado...");
                                break;
                            }
                        

                        }
                
                    }
                }else{
                    Console.WriteLine("\nNo se puede proceder, Lista vacia");
                }
                
                
                

            }
        }
        
        
    }
}