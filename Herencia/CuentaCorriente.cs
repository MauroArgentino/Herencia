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
	/// Description of CuentaCorriente.
	/// </summary>
	public class CuentaCorriente : CuentaBancaria
	{
		private readonly Double _limiteSobreGiro;
		
		public CuentaCorriente(Double limiteSobreGiro)
		{
			_limiteExtraccionDiaria = 20000;
			_limiteTransferenciaElectronica = 10000000;
			_limiteSobreGiro = limiteSobreGiro;
			//inicializaMovimientos();
		}
		
		public bool extraerMonto(Double monto, int indice) {
			if (obtieneSaldo() - monto < _limiteSobreGiro) {
				return true;
			} else {
				movimientos[indice].importe = monto;
				movimientos[indice].fecha = fechaAleatoria();
				movimientos[indice].tipoMovimiento = tipoMovimientoAleatorio(0, 2);
				return false;
			}
			
		}
	}
}
