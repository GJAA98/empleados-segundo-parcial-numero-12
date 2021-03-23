using System;

namespace empleados_segundo_parcial_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Cargar();
        }

        static void Cargar()
        {
            Console.WriteLine("Inserte los datos de 5 empleados:");
            Console.WriteLine("------------");
            Empleado[] empleados = new Empleado[5];
            for (int i = 0; i < empleados.Length; i++)
            {
                empleados[i] = new Empleado();
                int numeroEmpleado = i + 1;
                Console.WriteLine("Inserte el nombre del empleado " + numeroEmpleado + ":");
                string nombre = Console.ReadLine();
                empleados[i].Nombre = nombre;
                Console.WriteLine("Inserte el salario del empleado " + numeroEmpleado + ":");
                string valor = Console.ReadLine();
                empleados[i].Salario = int.Parse(valor);
            }
            SalarioMayor(empleados);
        }

        static void SalarioMayor(Empleado[] empleados)
        {
            Empleado empleadoSueldoMayor=new Empleado();
            for (int i = 0; i < empleados.Length; i++)
            {
                if (empleados[i].Salario > empleadoSueldoMayor.Salario)
                {
                    empleadoSueldoMayor = empleados[i];
                }
            }
            Console.WriteLine("El empleado con el salario mayor es {0}",empleadoSueldoMayor.Nombre);
            Console.WriteLine("Tiene un salario de: {0}",empleadoSueldoMayor.Salario);
        }

    }
}
