using System;

namespace Serpis.Ed
{
	
	
	public class MyArray
	{
		public static void Main (string[] args)
		{
			//int[] v = new int[]{5, 15, 12, 7, 3, 9};
			
			//SelectionSort<int>(v);
			
			//show<int>(v);
			
			Persona[] personas = new Persona[] {
				new Persona("Dani", new DateTime(1969, 2, 25)),
				new Persona("David", new DateTime(1999, 3, 1)),
				new Persona("Blanca", new DateTime(1988, 2, 25)),
				new Persona("Ana", new DateTime(1990, 2, 25)),
				new Persona("Adam", new DateTime(1970, 2, 25)),
				new Persona("Belén", new DateTime(1983, 2, 25))
			};
			
			
			
			
//			SelectionSort<Persona>(personas);
//			show<Persona>(personas);
			
//			int x = 33;
//			int y = 77;
//			Swap(ref x, ref y);
			
		}
		
		private static void show<T>(T[] v) {
			for (int index = 0; index < v.Length; index++)
				Console.WriteLine("v[{0}]={1}", index, v[index]);
			
		}
		
		public static int IndexOfMin<T>(T[] v, int startIndex) where T : IComparable<T> {
			int indexOfMin = startIndex;
			for (int index = startIndex + 1; index < v.Length; index++)
				if (v[index].CompareTo(v[indexOfMin]) < 0)
					indexOfMin = index;
			return indexOfMin;
		}
		
//		public static void Swap(ref int a, ref int b) {
//			int temp = a;
//			a = b;
//			b = temp;
//		}
		
		public static void Swap<T>(ref T a, ref T b) {
			T temp = a;
			a = b;
			b = temp;
		}

		private static void selectionSortV2<T>(T[] v) where T : IComparable<T>{
			for (int selectedIndex = 0; selectedIndex < v.Length - 1; selectedIndex++) {
				int indexOfMin = IndexOfMin<T>(v, selectedIndex);
				Swap<T>(ref v[selectedIndex], ref v[indexOfMin]);				
			}
		}

		public static void SelectionSort<T>(T[] v) where T : IComparable<T> {
			selectionSortV2<T>(v);
		}
		
		private static void selectionSortV1<T>(T[] v) where T : IComparable<T> {
			int count = v.Length;
			for (int selectedIndex = 0; selectedIndex < count - 1; selectedIndex++) {
				int indexOfMin = selectedIndex;
				for (int index = selectedIndex + 1; index < count; index++)
					if (v[index].CompareTo(v[indexOfMin]) < 0)
						indexOfMin = index;
				T temp = v[selectedIndex];
				v[selectedIndex] = v[indexOfMin];
				v[indexOfMin] = temp;
			}
		}
		
		public static void SelectionSort<T>(T[] v, Comparison<T> 
	}
}
