using System;

namespace RelojCronometro
{
	class Principal
	{
		public void MenuDeMiPrograma(){
			Console.Write("Bienvenido Elige La Herramienta:\n ");
			
			Console.Write("*************TECLEA:************\n ");
			Console.Write("1- PARA RELOJ\n 2- CRONOMETRO: ");
		}
		
		
		public void RecibeOpcion(){
			int opcion = int.Parse(Console.ReadLine());
			if(opcion == 1){
				Reloj reloj = new Reloj();
				reloj.inicializar();
			}else{
				Cronometro cronometro = new Cronometro();
				cronometro.inicializar();
			}
		}
		
		public static void Main (string[] args)
		{

			Principal programa = new Principal();
			programa.MenuDeMiPrograma();
			programa.RecibeOpcion();
		}
	}
}
