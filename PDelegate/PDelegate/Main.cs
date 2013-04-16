using System;

namespace PDelegate
{
	public delegate int MiFuncAB(int a, int b);
	
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			
			int aleatorio = new Random().Next(4); //0..3
			
			MiFuncAB[] miFunABs = new MiFuncAB[]{suma, resta, producto, division};
			
			MiFuncAB miFunAB = miFunABs[aleatorio];
			
//			switch (aleatorio){
//			case 0: miFunAB = suma;
//				break;
//			case 1:miFunAB = resta;
//				break;
			
			Console.WriteLine("aleatorio = {0} valor = {1}", aleatorio, miFunAB(5, 2));
			
		}
		
		private static int suma(int a, int b){
		return a + b;
		}
		
		private static int resta(int a, int b){
		return a - b;
		}
		
		private static int producto(int a, int b){
		return a * b;
		}
		
		private static int division(int a, int b){
		return a / b;
		}
	}
		
}
