/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 7 may. 2021
 * Hora: 07:33
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Globalization;

namespace Herencia
{
	/// <summary>
	/// Description of GUI.
	/// </summary>
	public class GUI
	{
		private String[] tipoCuenta = {"C A J A   D E   A H O R R O", "C U E N T A   C O R R I E N T E"};
		
		public void pantallaPrincipal()
		{
			//Console.Clear();
			Console.Write("╔");
			for (int i = 0; i < Console.WindowWidth - 2; i++) {
				Console.Write("═");
			}
			Console.Write("╗");
			Console.Write("║");
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.SetCursorPosition(2, 1);
			Console.Write("                                     N U E V O   B A N C O   D E L   C H A R C O                                    ");
			Console.ResetColor();
			Console.Write(" ║");
			Console.Write("╠");
			for (int i = 0; i < Console.WindowWidth - 2; i++) {
				Console.Write("═");
			}
			Console.Write("╣");
			Console.Write("║");
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(2, 3);
			Console.Write("  TIPO DE CUENTA	                                                                                SALDO PARCIAL ");
			Console.ResetColor();
			Console.Write(" ║");
			Console.Write("╠");
			for (int i = 0; i < Console.WindowWidth - 2; i++) {
				Console.Write("═");
			}
			Console.Write("╣");
			for (int i = 5; i < Console.WindowHeight - 2; i++) {
				Console.SetCursorPosition(0, i );
				Console.Write("║");
			}
			for (int i = 5; i < Console.WindowHeight - 2; i++) {
				Console.SetCursorPosition(Console.WindowWidth - 1, i );
				Console.Write("║");
			}
			Console.Write("╚");
			for (int i = 0; i < Console.WindowWidth - 2; i++) {
				Console.Write("═");
			}
			Console.Write("╝");
			
		 	Console.SetCursorPosition(0, 29);
		    Console.BackgroundColor = ConsoleColor.White;
		    Console.ForegroundColor = ConsoleColor.Black;
		    Console.Write("SELECCIONE UNA DE LAS CUENTAS CON LAS FLECHAS SUBIR Y BAJAR. PRESIONE ENTER PARA VER LOS MOVIMIENTOS.");
		    Console.ResetColor();
		    Console.CursorVisible = false;
			
		}
		
		public void pantallaMovimientos(int indiceTipoCuenta)
		{
			Console.Clear();
			Console.Write("╔");
			for (int i = 0; i < Console.WindowWidth - 2; i++) {
				Console.Write("═");
			}
			Console.Write("╗");
			Console.Write("║");
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.SetCursorPosition(2, 1);
			Console.Write("                                     N U E V O   B A N C O   D E L   C H A R C O                                    ");
			Console.ResetColor();
			Console.Write(" ║");
			Console.Write("╠");
			for (int i = 0; i < Console.WindowWidth - 2; i++) {
				Console.Write("═");
			}
			Console.Write("╣");
			Console.Write("║");
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(2, 3);
			if (indiceTipoCuenta == 0){
				Console.Write("                         M O V I M I E N T O S   D E   L A   {0}                            ", tipoCuenta[indiceTipoCuenta]);
			} else {
				Console.Write("                        M O V I M I E N T O S   D E   L A   {0}                         ", tipoCuenta[indiceTipoCuenta]);
			}
			Console.ResetColor();
			Console.Write(" ║");
			Console.Write("╠");
			for (int i = 0; i < Console.WindowWidth - 2; i++) {
				Console.Write("═");
			}
			Console.Write("╣");
			Console.Write("║");
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.SetCursorPosition(2, 5);
			Console.Write("    F E C H A      	C O N C E P T O                                                                     M O N T O ");
			Console.ResetColor();
			Console.Write(" ║");
			Console.Write("╠");
			for (int i = 0; i < Console.WindowWidth - 2; i++) {
				Console.Write("═");
			}
			Console.Write("╣");
			for (int i = 7; i < Console.WindowHeight - 2; i++) {
				Console.SetCursorPosition(0, i );
				Console.Write("║");
			}
			for (int i = 7; i < Console.WindowHeight - 2; i++) {
				Console.SetCursorPosition(Console.WindowWidth - 1, i );
				Console.Write("║");
			}
			Console.Write("╚");
			for (int i = 0; i < Console.WindowWidth - 2; i++) {
				Console.Write("═");
			}
			Console.Write("╝");
			
		}
		
		public bool muestraMovimientos(CuentaBancaria.Movimiento[] movimientos, String[,] tipoMovimiento){
			Random aleatorioTipoMovimiento = new Random();
			
			bool salir = false;
			int itemActual = 0;
						
			ConsoleKeyInfo tecla;
			Console.SetCursorPosition(0, 29);
		 	Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Write(" PRESIONE ESC PARA VOLVER AL MENÚ DE CUENTAS.");
			Console.ResetColor();
			Console.CursorVisible = false;
			
			do
			{
			   
			   	Console.SetCursorPosition(2, 7);
				  
			   	if (itemActual < 21){
			    	for (int i = 0; i < 21; i++) {
			  			refrescar(movimientos, tipoMovimiento, ref itemActual, i, i);
			     	}
			   		
			   	} else {
			   		int renglon = itemActual - 20;
			   		for (int i = 0; i < 21; i++) {
			   			refrescar(movimientos, tipoMovimiento, ref itemActual, renglon, i);
			            renglon++;
			   		}
			   	}
			    
			    tecla = Console.ReadKey(true);
			
			    if (tecla.Key == ConsoleKey.DownArrow) {
			        itemActual++;
			        if (itemActual > movimientos.Length - 1) {
			        	itemActual = movimientos.Length - 1;
			        	Console.Beep();
			        }
			    } else if (tecla.Key == ConsoleKey.UpArrow) {
			        itemActual--;
			        if (itemActual < 0) {
			        	itemActual = 0;
			        	Console.Beep();
			        }
			    }
			    
			    if(tecla.Key == ConsoleKey.Escape) {
					salir = true;
					Console.Clear();
					pantallaPrincipal();
			    }
			    
			} while (tecla.Key != ConsoleKey.Escape);
			return salir;
			
		}
			
		private void refrescar(CuentaBancaria.Movimiento[] movimientos, String[,] tipoMovimiento, ref int itemActual, int indice, int i){

			Console.SetCursorPosition(2, 7 + i );
			if (itemActual == indice) {
			   			 
	            Console.BackgroundColor = ConsoleColor.White;
				if (0 == movimientos[indice].tipoMovimiento || 1 == movimientos[indice].tipoMovimiento ){
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("{0} ", movimientos[indice].fecha.ToString("g", CultureInfo.CreateSpecificCulture("es-ES")));
	            	Console.ForegroundColor = ConsoleColor.Black;
					Console.Write("│");
					Console.ForegroundColor = ConsoleColor.Red;
	            	Console.Write("\t{0}\t\t\t\t\t\t\t\t\t\t   -$ {1,8:N2}", tipoMovimiento[movimientos[indice].tipoMovimiento, 1], movimientos[indice].importe);
				} else if (2 == movimientos[indice].tipoMovimiento || 3 == movimientos[indice].tipoMovimiento ){
					Console.ForegroundColor = ConsoleColor.Black;
					Console.Write("{0} │", movimientos[indice].fecha.ToString("g", CultureInfo.CreateSpecificCulture("es-ES")) );
					Console.Write("\t{0}\t\t\t\t\t\t\t\t\t\t    $ {1,8:N2}", tipoMovimiento[movimientos[indice].tipoMovimiento, 1], movimientos[indice].importe);
				}
			} else {
				if (0 == movimientos[indice].tipoMovimiento || 1 == movimientos[indice].tipoMovimiento ){
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("{0} ", movimientos[indice].fecha.ToString("g", CultureInfo.CreateSpecificCulture("es-ES")));
	            	Console.ForegroundColor = ConsoleColor.White;
					Console.Write("│");
					Console.ForegroundColor = ConsoleColor.Red;
        			Console.Write("\t{0}\t\t\t\t\t\t\t\t\t\t   -$ {1,8:N2}", tipoMovimiento[movimientos[indice].tipoMovimiento, 1], movimientos[indice].importe);
    			} else if (2 == movimientos[indice].tipoMovimiento || 3 == movimientos[indice].tipoMovimiento ){
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("{0} │", movimientos[indice].fecha.ToString("g", CultureInfo.CreateSpecificCulture("es-ES")) );
					Console.Write("\t{0}\t\t\t\t\t\t\t\t\t\t    $ {1,8:N2}", tipoMovimiento[movimientos[indice].tipoMovimiento, 1], movimientos[indice].importe);
				}
			}
			Console.ResetColor();
		}
		
		public bool seleccionCuenta(CajaAhorro oCajaAhorro, CuentaCorriente oCuentaCorriente, ref int itemActual, ref bool salirMovimientos){
			string[] menuItems = { " CAJA AHORRO ", " CUENTA CORRIENTE " };
			bool salirCuentas = true;
			bool salirAplicacion = false;
			
			ConsoleKeyInfo tecla;
			
			do
			{
				
			  	Console.SetCursorPosition(1, 5);
				 
  		    	for (int i = 0; i < menuItems.Length; i++) {
			   		Console.SetCursorPosition(2, 5 + i );
			        if (itemActual == i) {
			   			Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
			            Console.Write(menuItems[i]);
			            Console.SetCursorPosition(104, 5 + i );
			            if (itemActual == 0) {
			            	Console.Write("$ {0,11:N2}", oCajaAhorro.obtieneSaldo());
			            } else {
			            	Console.Write("$ {0,11:N2}", oCuentaCorriente.obtieneSaldo());
			            }
			        } else {
			   			Console.WriteLine(menuItems[i]);
			            Console.SetCursorPosition(104, 5 + i );
			            if (itemActual == 0) {
			            	Console.Write("$ {0,11:N2}", oCuentaCorriente.obtieneSaldo());
			            } else {
			            	Console.Write("$ {0,11:N2}", oCajaAhorro.obtieneSaldo() );
			            }
			        }
			   		Console.ResetColor();
			    }
			   
			    tecla = Console.ReadKey(true);
			
			    if (tecla.Key == ConsoleKey.DownArrow) {
			        itemActual++;
			        if (itemActual > menuItems.Length - 1) {
			        	itemActual = 0;
			        }
			    } else if (tecla.Key == ConsoleKey.UpArrow) {
			        itemActual--;
			        if (itemActual < 0) {
			        	itemActual = Convert.ToInt16(menuItems.Length - 1);
			        }
			    }
			    
			    switch (tecla.Key) {
			    	case ConsoleKey.Enter:
											switch (itemActual) {
													case 0 :
														Console.Clear();
														pantallaMovimientos(itemActual);
														salirMovimientos = muestraMovimientos(oCajaAhorro.obtieneMovimientos(), oCajaAhorro.obtieneTipoMovimiento());
														break;
													case 1 :
														Console.Clear();
														pantallaMovimientos(itemActual);
														salirMovimientos = muestraMovimientos(oCuentaCorriente.obtieneMovimientos(), oCuentaCorriente.obtieneTipoMovimiento());
														break;
													default:
														
														break;
												}
			    							break;
			    		case ConsoleKey.Escape: 
									    	salirAplicacion = preguntaSalir();
									    	
									    	if (salirAplicacion == false) {
									    		limpiaSalir();
									    	} else {
									    		salirCuentas = false;
									    	}
											break;
			    }
			} while (salirCuentas);
			return salirAplicacion;
		}
		
		private bool preguntaSalir(){
			string[] menuItems = { "  SI  ", "  NO  " };
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.SetCursorPosition((Console.WindowWidth / 2) - 15, (Console.WindowHeight / 2) - 3);
			Console.WriteLine("                            ");
			Console.SetCursorPosition((Console.WindowWidth / 2) - 15, (Console.WindowHeight / 2) - 2);
			Console.WriteLine("       ¿DESEA SALIR?        ");
			Console.SetCursorPosition((Console.WindowWidth / 2) - 15, (Console.WindowHeight / 2) - 1);
			Console.WriteLine("                            ");
			Console.SetCursorPosition((Console.WindowWidth / 2) - 15, (Console.WindowHeight / 2));
			Console.Write("  {0}         {1}     ", menuItems[0], menuItems[1]);
			
			Console.SetCursorPosition((Console.WindowWidth / 2) - 15, (Console.WindowHeight / 2) + 1);
			Console.WriteLine("                            ");
			
			bool salir = false;
			int itemActual = 1;
						
			ConsoleKeyInfo tecla;
			
			do
			{
			   
			   	Console.SetCursorPosition(1, 5);
				  
  		    	for (int i = 0; i < menuItems.Length; i++) {
			   		
			        if (itemActual == i) {
			   			Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						if (itemActual == 0){
							Console.SetCursorPosition((Console.WindowWidth / 2) - 12, (Console.WindowHeight / 2));
			            	Console.Write(menuItems[0]);
						} else {
							Console.SetCursorPosition((Console.WindowWidth / 2) + 4, (Console.WindowHeight / 2));
							Console.Write(menuItems[1]);
						}
			        } else {
			   			Console.BackgroundColor = ConsoleColor.Blue;
			   				Console.ForegroundColor = ConsoleColor.White;
			   			if (itemActual == 1){
			   				Console.SetCursorPosition((Console.WindowWidth / 2) - 12, (Console.WindowHeight / 2));
			   				Console.Write(menuItems[0]);
						} else {
			   				Console.SetCursorPosition((Console.WindowWidth / 2) + 4, (Console.WindowHeight / 2));
			   				Console.Write(menuItems[1]);
						}
			   		}
			    }
			    
			    Console.CursorVisible = false;
			    tecla = Console.ReadKey(true);
			
			    if (tecla.Key == ConsoleKey.LeftArrow) {
			        itemActual++;
			        if (itemActual > menuItems.Length - 1) {
			        	itemActual = 0;
			        }
			    } else if (tecla.Key == ConsoleKey.RightArrow) {
			        itemActual--;
			        if (itemActual < 0) {
			        	itemActual = Convert.ToInt16(menuItems.Length - 1);
			        }
			    }
			    
			    if(tecla.Key == ConsoleKey.Enter) {
					switch (itemActual) {
								case 0 :
									salir = true;
									break;
								case 1 :
									salir = false;
									break;
								default:
									Console.WriteLine("Ha ingresado una opción incorrecta.");
									break;
							}
			    } 
			} while (tecla.Key != ConsoleKey.Enter);
			return salir;
		}
		
		private void limpiaSalir(){
			Console.ResetColor();
			for (int i = -3; i < 3; i++) {
				Console.SetCursorPosition((Console.WindowWidth / 2) - 15, (Console.WindowHeight / 2) + i);
			    Console.WriteLine("                            ");
			}
			
		}
	}
}
