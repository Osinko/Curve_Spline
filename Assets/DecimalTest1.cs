using UnityEngine;
using System.Collections;

public class DecimalTest1 : MonoBehaviour
{
		void Start ()
		{
				float x = 1.2345678912345f * Mathf.Pow (10, -30);
				float y = 4.321f * Mathf.Pow (10, -30);
				float z = 2.0f;
				float bom = 0.1f;
				print (x);
				print (y);
				print (x + y);
				print (x * z);
				print (x + y + bom);
		}
}
