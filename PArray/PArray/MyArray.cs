using System;

namespace Serpis.Ed
{
	public class MyArray
	{
		public static void Main (string[] args){
			int[] v = new int[]{5, 15, 12, 7, 3, 9};
			
			SelectionSort<int>(v);
			
			show (v);
			
	//		int x = 33;
	//		int y = 77;
	//		Swap(ref x, ref y);
			
		}
		
		private static void show<T>(T[] v){
			for (int index=0; index< v.Length; index++)
				Console.WriteLine("v[{0}]={1}", index, v[index]);
		}
		
//		public static int IndexOfMin(int[] v){
//			int indexOfMin =0;
//			for (int index=1; index < v.Length; index ++)
//				if (v[index] < v[indexOfMin])
//					indexOfMin = index;
			
//			return indexOfMin;
//		}
		
//		public static int IndexOfMin(int[] v, int startIndex){
//			int indexOfMin = startIndex;
//			for (int index= startIndex + 1; index < v.Length; index ++)
//				if (v[index] < v[indexOfMin])
//					indexOfMin = index;
			
//			return indexOfMin;
//		}
		
		public static int IndexOfMin<T>(T[] v, int startIndex) where T : IComparable<T>{
			int indexOfMin = startIndex;
			for (int index= startIndex + 1; index < v.Length; index ++)
				if (v[index].CompareTo(v[indexOfMin]) < 0 )
					indexOfMin = index;
			
			return indexOfMin;
		}
		
//		public static void Swap(ref int a, ref int b){
//			int temp = a;
//			a = b;
//			b = temp;
//		}
		
		// metodo generico donde la T es un tipo y la sustituyo solo en <T> cuando llamo al metodo
		public static void Swap<T>(ref T a, ref T b){
			T temp = a;
			a = b;
			b = temp;
		}
		
		public static void SelectionSort<T>(T[] v) where T : IComparable<T>{
			SelectionSortV2<T> (v);
		}
		
//		public static void SelectionSortV1(int[] v){
			
//			for (int selectedIndex = 0; selectedIndex < v.Length -1; selectedIndex++){
//				int indexOfMin = selectedIndex;
//				for (int index = selectedIndex +1; index < v.Length; index++)
//					if (v[index].CompareTo(v[indexOfMin]) < 0)
//						indexOfMin = index;
	
//				int temp = v[selectedIndex];
//				v[selectedIndex] = v[indexOfMin];
//				v[indexOfMin] = temp;
//			}
//		}
	

// hacemos un metodo generico para la interfaz IComparable		
		public static void SelectionSortV1<T>(T[] v) where T : IComparable<T>{
			
			for (int selectedIndex = 0; selectedIndex < v.Length -1; selectedIndex++){
				int indexOfMin = selectedIndex;
				for (int index = selectedIndex +1; index < v.Length; index++)
					if (v[index].CompareTo(v[indexOfMin]) < 0)
						indexOfMin = index;
	
				T temp = v[selectedIndex];
				v[selectedIndex] = v[indexOfMin];
				v[indexOfMin] = temp;
			}
		}
		
//		public static void SelectionSortV2(int[] v){
//			for (int selectedIndex = 0; selectedIndex < v.Length -1; selectedIndex++){
//				int indexOfMin = IndexOfMin(v, selectedIndex);
//				Swap<int>(ref v[selectedIndex], ref v[indexOfMin]);
//			}
//		}
		
// hacemos un metodo generico para la interfaz IComparable		
		public static void SelectionSortV2<T>(T[] v) where T : IComparable<T>{
			for (int selectedIndex = 0; selectedIndex < v.Length -1; selectedIndex++){
				int indexOfMin = IndexOfMin(v, selectedIndex);
				Swap<T>(ref v[selectedIndex], ref v[indexOfMin]);
			}
		}
	}
}