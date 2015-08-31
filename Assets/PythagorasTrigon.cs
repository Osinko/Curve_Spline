using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PythagorasTrigon : MonoBehaviour
{
		void Start ()
		{
				IEnumerable<int> primeNum = Pythagoras (100, true);
				foreach (var item in primeNum) {
						print (item);
				}
		}

		IEnumerable <int> Pythagoras (int range, bool one=false)
		{
				IEnumerable<int> numbers, primeNum;
		
				numbers = GetRange (range);
				//エラトステネスの篩のアルゴリズムを利用する
				primeNum = numbers.Where (p => p != 1 && p % 2 != 0 && p % 3 != 0 && p % 5 != 0 && p % 7 != 0 || p == 2 || p == 3 || p == 5 || p == 7);

				if (one) {
						yield return 1;
				}

				foreach (var item in primeNum) {
						yield return item;
				}
		}
	
		public static IEnumerable <int> GetRange (int num)
		{
				for (int i = 0; i < num; i++) {
						yield return i;
				}
		}
}
