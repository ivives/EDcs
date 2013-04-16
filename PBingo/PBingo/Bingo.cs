using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Serpis.EDcs
{
	public class Bingo
	{
		private List<int> bolas = new List<int>();
		
		private int numeroInicialBolas = 90; //se podrá cambiar
		public int NumeroInicialBolas {
			get { return numeroInicialBolas;}
			set {
				if (value <= 0)
					return;
				numeroInicialBolas = value;
			}
		}
		
		/// <summary>
		/// Llena el bombo con las bolas.
		/// </summary>
			public void Iniciar(){
			bolas.Clear();
			for (int numero = 1; numero <= numeroInicialBolas; numero ++)
				bolas.Add (numero);
		}
		
		public int ExtraeBola() {
			int numeroAleatorio = new Random().Next(bolas.Count);
			int bola = bolas[numeroAleatorio];
			
			bolas.Remove(bola);
			
			return bola;
		}
		
		public static void Cantar(int bola){
			// TODO resolver implementacion
			string fileName = "espeak";
			string arguments = "-v es \"14 1 4\"";
		
			Process.Start(fileName, arguments);
	}
	}
}