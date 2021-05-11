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
	/// Description of CajaAhorro.
	/// </summary>
	public class CajaAhorro : CuentaBancaria
	{
		public CajaAhorro()
		{
		}
				
		public bool extraerMonto(Double monto, int indice) {
			if (obtieneSaldo() < monto) {
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
