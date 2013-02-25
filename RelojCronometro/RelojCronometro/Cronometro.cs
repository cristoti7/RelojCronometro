using System;

namespace RelojCronometro
{
	public class Cronometro
	{
		public Cronometro ()
		{
		}
		
		public void inicializar ()
		{
			int horas = 0, minutos = 0, segundos = 0;
			Console.WriteLine ("Cronometro inicializado");

				for (horas=0; horas<24; horas++) {
					for (minutos=0; minutos<60; minutos++) {
						for (segundos=0; segundos<60; segundos++) {
							Console.WriteLine ("{0}:{1}:{2}", horas, minutos, segundos);
							System.Threading.Thread.Sleep (1000);
							Console.Clear ();
                             
						}
					}
				}
			}
		}
	}


