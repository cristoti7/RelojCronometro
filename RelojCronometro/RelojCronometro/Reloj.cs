using System;

namespace RelojCronometro
{
	public class Reloj
{
	public Reloj ()
	{
	}
	
	public void inicializar ()
		{
		
			Console.WriteLine ("Programa de un Reloj");
			int h = DateTime.Now.Hour;
			int m = DateTime.Now.Minute;
			int s = DateTime.Now.Second;
			int x;
			while (true) {
				Console.WriteLine ("La hora actual  es  {0}:{1}:{2}", h, m, s);
				
				x = Environment.TickCount;
				
				while (Environment.TickCount <= x + 1000)
					;
				s = s + 1;
				
				if (s == 60) {
					s = 0;
					m = m + 1;
					if (m == 60) {
						m = 0;
						h = h + 1;
						if (h == 24) {
							h = 0;
							
						}
					}
				}
			}
			
			
			
			
			
			
			
		}
			

}
}

