/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 7 may. 2021
 * Hora: 09:04
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Herencia
{
	/// <summary>
	/// Description of Cuenta.
	/// </summary>
	public class Cuenta
	{
		public struct Movimiento {
			public DateTime fecha;
			public Double importe;
		 	public int tipoMovimiento;
		};
		
		String[] tipoMovimiento = { "EXTLINK", "DEBCAMA", "SUELDO", "INCINT" };
		Movimiento[] movimientos = new Movimiento[100];
		
		public Cuenta()
		{
			inicializaMovimientos();
			ordenaMovimientos(movimientos);
		}
		
		private DateTime fechaAleatoria(){
			DateTime inicial = new DateTime(2020, 1, 1);
			Random generador = new Random(Guid.NewGuid().GetHashCode());
			TimeSpan diferencia = DateTime.Today - inicial;
			int rango = diferencia.Days;
			return inicial.AddDays(generador.Next(0, rango));
		}
		
		private void inicializaMovimientos(){
			Random movimientoAleatorio = new Random();
			Random importeAleatorio = new Random();
			
			for (int i = 0; i < movimientos.Length; i++) {
				movimientos[i].fecha = fechaAleatoria();
				movimientos[i].importe = (Double) importeAleatorio.Next(10, 10000) + importeAleatorio.NextDouble();
				movimientos[i].tipoMovimiento = movimientoAleatorio.Next(0, 4);
			}
			
		}
		
		private void ordenaMovimientos(Movimiento[] movimientos){
			Array.Sort<Movimiento>(movimientos, (x,y) => x.fecha.CompareTo(y.fecha));
			Array.Reverse(movimientos);
		}
		
		public Movimiento[] obtieneMovimientos(){
			
			return movimientos;
		}
		
		public String[] obtieneTipoMovimiento(){
			
			return tipoMovimiento;
		}
		
		public double obtieneSaldo() {
			double saldo = 0;
			for (int i = 0; i < 10; i++) {
				if (movimientos[i].tipoMovimiento == 0 || movimientos[i].tipoMovimiento == 1) {
				saldo -= movimientos[i].importe;
				} else {
					saldo += movimientos[i].importe;
				}
			}
			
			return saldo;
		}
		
	}
}
