using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Practicas_Guia_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1 de la guía 3: Ingresar edad para obtener licencia de conducir
            //La edad tiene que ser mayor de 18 

            Console.WriteLine("Ingrese su edad");

            int edad = Convert.ToInt32(Console.ReadLine());
            if (edad > 18)
            {
                Console.WriteLine("Edad permitida para obtener licencia de conducir");
            }
            else
            {
                Console.WriteLine("Edad insuficiente para obtener licencia de conducir");
            }


            //Ejercicio 2 de la guía 3: Ingresa tus datos para ingresar a evento
            //Los datos que debe ingresar pertenecen a una lista de invitados

            Console.WriteLine("Ingrese su nombre y edad");

            string nombre = ("ABC");
            int edad2 = 20;

            nombre = Convert.ToString(Console.ReadLine());
            edad2 = Convert.ToInt32(Console.ReadLine());

            if (nombre == ("ABC") && edad2 == 20)
            {
                Console.WriteLine("Puede pasar");
            }
            else
            {
                Console.WriteLine("No tiene invitación");
            }


            //Ejercicio 3 de la guía 3: Ingresar edad para obtener descuento en el cine
            //La edad requerida es de 18 años o mayor

            Console.WriteLine("Ingrese su edad");

            int edad3;
            edad3 = Convert.ToInt32(Console.ReadLine());
            if (edad3 >= 18)
            {
                Console.WriteLine("Felicidades a obtenido un descuento");
            }
            else
            {
                Console.WriteLine("No es posible realizar descuentos");
            }


            //Ejercicio 4 de la guía 3: Ingresar nota de asignatura
            //La nota de aprobación debe ser mayor o igual a 4

            Console.WriteLine("Ingrese su calificaión");

            double calificaión = Convert.ToDouble(Console.ReadLine());

            if (calificaión >= 4)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Desaprobado");
            }


            //Ejercicio 5 de la guía 3: Verificación de contraseña

            Console.WriteLine("Ingrese su contraseña");

            string contraseña = Convert.ToString(Console.ReadLine());

            if (contraseña == "colegioidra21")
            {
                Console.WriteLine("Cotraseña correcta");
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta");
            }


            //Ejercicio 6 de la guía 3: Comprobando edad para red social
            //La edad requerida es que sea mayor o igual a 18

            Console.WriteLine("Ingrese su edad");

            byte edad4 = Convert.ToByte(Console.ReadLine());
            
            if (edad4 >=18)
            {
                Console.WriteLine("Bienvenido/a!");
            }
            else
            {
                Console.WriteLine("Acceso denegado. Edad insuficiente");
            }


            //Ejercicio 7 de la guía 3: Pagando impuestos :(
            //Se paga impuesto a partir de que el salario sea de 699.998

            Console.WriteLine("Ingrese su salario");

            double salario = Convert.ToDouble(Console.ReadLine());

            if (salario >= 699.998)
            {
                Console.WriteLine("Felicidades! Debe pagar impuestos");
            }
            else
            {
                Console.WriteLine("Felicidades! No paga impuestos");
            }


            //Ejercicio 8 de la guía 3: Dar datos para ingresar al bar
            //El nombre importa siempre que tenga la edad permitida

            Console.WriteLine("Ingrese su nombre y edad para ingresar al bar");

            string nombre2;
            int edad5;

            nombre2 = Convert.ToString(Console.ReadLine());
            edad5 = Convert.ToInt32(Console.ReadLine());

            if (edad5 >= 18)
            {
                Console.WriteLine("Bienvenido " +nombre2+ "! Puedes pasar");
            }
            else
            {
                Console.WriteLine("Lo siento " +nombre2+ " No puedes pasar");
            }


            //Ejercicio 9 de la guía 3: Mínima cantidad de asistencias requeridas
            //La cantidad requerida es de 20 asistencias

            Console.WriteLine("Ingrese la cantidad de asistencias a clases");

            int asistencias;
            asistencias = Convert.ToInt32(Console.ReadLine());

            if (asistencias >=20)
            {
                Console.WriteLine("Felicidades! Tiene la asistencia requerida");
            }
            else
            {
                Console.WriteLine("No cumple con la asistencia requerida");
            }


            //Ejercicio 10 de la guía 3: Validación de número de telefono 

            Console.WriteLine("Ingrese su número de telefono");

            string telefono = Convert.ToString(Console.ReadLine());

            if (telefono == "3765137796")
            {
                Console.WriteLine("Número de telefono correcto");
            }
            else
            {
                Console.WriteLine("Número de telefono incorrecto");
            }


            //Ejercicio 11 de la guía 3: Calculando descuento en tienda
            //Los productos con descuentos tienen un monto mayor a 499

            Console.WriteLine("Ingrese el precio del producto");

            double precio = Convert.ToDouble(Console.ReadLine());

             if (precio >= 499)
            {
                Console.WriteLine("Tiene acceso a un descuento");
            }
             else
            {
                Console.WriteLine("Producto sin descuento");
            }


            //Ejercicio 12 de la guía 3: Verificación de stock de artículo
            //La cantitdad mínima de artículos es 5

            Console.WriteLine("Ingrese la cantidad del artículo que necesita");

            int articulo = Convert.ToInt32(Console.ReadLine());

            if (articulo > 5)
            {
                Console.WriteLine("Cantidad no disponible");
            }
            else
            {
                Console.WriteLine("Cantidad disponible");
            }


            //Ejercicio 13 de la guía 3: Aprobación de crédito
            // Se requiere un mínimo de 500 puntos

            Console.WriteLine("Ingrese el puntaje para determindar su aprobación");

            int puntos = Convert.ToInt32(Console.ReadLine());

            if (puntos >= 500)
            {
                Console.WriteLine("Felicidades! Pudo obtener un préstamo");
            }
            else
            {
                Console.WriteLine("Lo sentimos! No alcanza los puntos necesarios");
            }


            //Ejercicio 14 de la guía 3: Verificación de correo electrónico

            Console.WriteLine("Ingrese su correo electrónico");

            string correo = Convert.ToString(Console.ReadLine());

            if (correo == "alfajor@gmail.com")
            {
                Console.WriteLine("Formato válido. Contraseña correcta");
            }
            else
            {
                Console.WriteLine("Formato inválido. Contraseña incorrecta");
            }


            //Ejercicio 15 de la guía 3: Comprobando disponibilidad de asientos
            // Se desea reservar 12 asientos para ver la funsión

            Console.WriteLine("Ingrese el números de asientos que desea reservar");

            int asientos = Convert.ToInt32(Console.ReadLine());

            if (asientos == 12)
            {
                Console.WriteLine("Asientos disponibles");
            }
            else
            {
                Console.WriteLine("Lo sentimo. La cantindad asientos no se encuentran disponibles");
            }
        }
    }
}
 