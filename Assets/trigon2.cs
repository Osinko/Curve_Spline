using UnityEngine;
using System.Collections;

public class trigon2 : MonoBehaviour
{
		void Start ()
		{
				float x = Mathf.Cos (60 * Mathf.Deg2Rad);
				float y = Mathf.Sin (60 * Mathf.Deg2Rad);
				print (Mathf.Pow (x, 2) + Mathf.Pow (y, 2)); 	//三平方の定理の効用が確認できる
		}
}
