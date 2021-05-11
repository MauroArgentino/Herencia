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
	/// Description of CuentaBancaria.
	/// </summary>
	public class CuentaBancaria
	{
		// Tipo de estructura que es utilizada para generar un arreglo
		public struct Movimiento {
			public DateTime fecha;
			public Double importe;
		 	public int tipoMovimiento;
		};
		
		protected Double _limiteExtraccionDiaria;
		
		// disable once ConvertToAutoProperty
		public Double limiteExtraccionDiaria {
			get {return _limiteExtraccionDiaria;}
			set { _limiteExtraccionDiaria = value;}
		}
		
		protected Double _limiteTransferenciaElectronica;
		
		// disable once ConvertToAutoProperty
		public Double limiteTransferenciaElectronica {
			get {return _limiteTransferenciaElectronica;}
			set { _limiteTransferenciaElectronica = value;}
		}
		
		String _titular;
		
		// disable once ConvertToAutoProperty
		public String titular {
			get {return _titular;}
			set { _titular = value;}
		}
		
		String _numeroCuenta;
		
		// disable once ConvertToAutoProperty
		public String numeroCuenta {
			get {return _numeroCuenta;}
			set { _numeroCuenta = value;}
		}
		
		// Movimientos o conceptos de cada movimiento bancario
		protected string[,] tipoMovimiento = new String[4, 2] { {"-", "EXTLINK"}, { "-", "DEBCAMA"} , {"+", "SUELDO"}, {"+", "INCINT"} };
		
		// Arreglo donde se almacenan los movimientos..
		protected Movimiento[] movimientos = new Movimiento[100];
		
		public CuentaBancaria()
		{			
			//inicializaMovimientos();
			//ordenaMovimientos(movimientos);
		}
		
		protected static DateTime fechaAleatoria(){
			DateTime inicial = new DateTime(2020, 1, 1);
			Random generador = new Random(Guid.NewGuid().GetHashCode());
			TimeSpan diferencia = DateTime.Today - inicial;
			int rango = diferencia.Days;
			return inicial.AddDays(generador.Next(0, rango));
		}
		
		public static int tipoMovimientoAleatorio(int min, int max){
			Random movimientoAleatorio = new Random(Guid.NewGuid().GetHashCode());
			
			return movimientoAleatorio.Next(min, max);
		}
		
		public static Double tipoImporteAleatorio(){
			Random importeAleatorio = new Random(Guid.NewGuid().GetHashCode());
			
			return (Double) importeAleatorio.Next(10, 10000) + importeAleatorio.NextDouble();
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
		
		public string[,] obtieneTipoMovimiento(){
			
			return tipoMovimiento;
		}
		
		public double obtieneSaldo() {
			double saldo = 0;
			for (int i = 0; i < 100; i++) {
				if (movimientos[i].tipoMovimiento == 0 || movimientos[i].tipoMovimiento == 1) {
				saldo -= movimientos[i].importe;
				} else {
					saldo += movimientos[i].importe;
				}
			}
			
			return saldo;
		}
		
		public bool despositarMonto(Double monto, int indice) {
			movimientos[indice].importe = monto;
			movimientos[indice].fecha = fechaAleatoria();
			movimientos[indice].tipoMovimiento = tipoMovimientoAleatorio(2, 4);
			return true;
		}
	}
}
