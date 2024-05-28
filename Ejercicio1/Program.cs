using System;
using System.Collections.Generic;
/*Una distribuidora necesita llevar un control de las tareas realizadas por sus empleados. Usted
forma parte del equipo de programación que se encargará de hacer el módulo en cuestión
que a partir de ahora se llamará módulo ToDo:
Tareas
Cada empleado tiene un listado de tareas a realizar.
Las estructuras de datos necesarias son las siguientes:
struct Tarea{
int TareaID; //Numerado en ciclo iterativo
char *Descripcion; //
int Duracion; // entre 10 – 100
};
1. Cree aleatoriamente N tareas pendientes.
2. Desarrolle una interfaz para mover las tareas pendientes a realizadas.
3. Desarrolle una interfaz para buscar tareas pendientes por descripción*/
class Program 
{
    public static void Main()
    {
        int id = 0;
        List<Empleado> tareasPendientes = new List<Empleado>();
        List<Empleado> tareaRealizadas = new List<Empleado>();
        while (true)
        {
            id ++;
            Console.WriteLine("\nIngrese una tarea a realizar");
            var tarea = Console.ReadLine();
            Console.WriteLine("Ingrese el tiempor de duracion de la tarea (10-100) en minutos");
            int duracion = Convert.ToInt32(Console.ReadLine());
            Empleado nuevoEmpleado = new Empleado{ID = id, Tarea = tarea, Duracion = duracion};
            tareasPendientes.Add(nuevoEmpleado);
            Console.WriteLine("\nDesea ingresar otra tarea?(s para si)");
            var respuesta = Console.ReadLine().ToLower();
            if (respuesta != "s")
            {
                break;
                
            }
        }
        
        Console.WriteLine("\n*************Tareas pendientes**********\n");
        foreach (var empleado in tareasPendientes)
        {
            Console.WriteLine($"IdTarea: {empleado.ID}| Tarea: {empleado.Tarea}| Duracion: {empleado.Duracion}min");
            Console.WriteLine();

        }
        while (true)
        {
            Console.WriteLine("Desea marcar alguna tarea como realizada? (s para si)");
            var marcarTarea = Console.ReadLine().ToLower();

            if (marcarTarea != "s")
            {
                break;
            }else{
                Console.WriteLine("\nIngrese el ID de la tarea");
                int idPendiente = Convert.ToInt32(Console.ReadLine());
                foreach (var item in tareasPendientes)
                {
                    if (item.ID == idPendiente)
                    {
                        
                        tareaRealizadas.Add(item);
                        tareasPendientes.Remove(item);
                        break;
                    }
                }

                
            }
        }
        
        if (tareaRealizadas.Count > 0)
        {
            Console.WriteLine("\n*************Tareas Realizadas**********\n");
            foreach (var empleado in tareaRealizadas)
            {
                Console.WriteLine($"IdTarea: {empleado.ID}| Tarea: {empleado.Tarea}| Duracion: {empleado.Duracion}min");
                Console.WriteLine();

            }
        }
        if (tareasPendientes.Count>0)
        {
            Console.WriteLine("\n*************Tareas pendientes**********\n");
            foreach (var empleado in tareasPendientes)
            {
                Console.WriteLine($"IdTarea: {empleado.ID}| Tarea: {empleado.Tarea}| Duracion: {empleado.Duracion}min");
                Console.WriteLine();

            }
        }

    }

}

