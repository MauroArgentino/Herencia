/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 *  Ejercicio Básico Herencia
	Cree una jerarquía de clases utilizando herencia
	Considere una cuenta bancaria, la que puede ser de dos tipos: C.A. o C.C.
	Una C.C. puede tener un tope de descubierto, y en tal caso posee intereses negativos
	Simule 100 transacciones (depósitos/extracciones) ingresando montos aleatorios que pueden ir de $10 a $10000
 * Fecha: 7 may. 2021
 * Hora: 07:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Herencia
{
	class Program
	{
		public static void Main(string[] args)
		{
			GUI interfaz = new GUI();
			Cuenta oCuenta;
			oCuenta = new Cuenta();
						   
			do {
				interfaz.pantallaPrincipal();
				interfaz.seleccionCuenta(oCuenta);
			} while (interfaz.muestraMovimientos(oCuenta.obtieneMovimientos(), oCuenta.obtieneTipoMovimiento()));
			
		    Console.ReadKey(true);
		}
	}
}