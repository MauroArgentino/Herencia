/*
 * Creado por SharpDevelop.
 * Alumnos: Montenegro, Mauro Javier.
		    Pascuet, José Elías.
		    Rodriguez, Gustavo Joaquín.
      		Rojas, Silvio.
       		Verza, Esteban.
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
			int seleccion = 0;
			bool salirMovimientos = true;
			bool salirAplicacion = false;
			CajaAhorro oCajaAhorro = new CajaAhorro();
			CuentaCorriente oCuentaCorriente = new CuentaCorriente(-1000000);
			Random aleatorio = new Random();
			
			
			for (int i = 0; i < 100; i++) {
				if (aleatorio.Next(0, 2) == 0) {
				    	oCajaAhorro.despositarMonto(CuentaBancaria.tipoImporteAleatorio(), i);
				} else {
					if (oCajaAhorro.extraerMonto(CuentaBancaria.tipoImporteAleatorio(), i)){
						i--;
					}
				}
			}
			
			for (int i = 0; i < 100; i++) {
				if (aleatorio.Next(0, 2) == 0) {
				    	oCuentaCorriente.despositarMonto(CuentaBancaria.tipoImporteAleatorio(), i);
				} else {
					if (oCuentaCorriente.extraerMonto(CuentaBancaria.tipoImporteAleatorio(), i)){
						i--;
					}
				}
			}
						   
			do {
				Console.Clear();
				interfaz.pantallaPrincipal();
				
				salirAplicacion = interfaz.seleccionCuenta(oCajaAhorro, oCuentaCorriente, ref seleccion, ref salirMovimientos);
//				if (salir) {
//				switch(seleccion) {
//						case 0: 
//							salir = interfaz.muestraMovimientos(oCajaAhorro.obtieneMovimientos(), oCajaAhorro.obtieneTipoMovimiento());
//							break;
//						case 1:
//							salir = interfaz.muestraMovimientos(oCuentaCorriente.obtieneMovimientos(), oCuentaCorriente.obtieneTipoMovimiento());
//							break;
//						default:
//							break;
//							
//					}
//				}
			} while (!salirAplicacion);
			
		    //Console.ReadKey(true);
		}
	}
}