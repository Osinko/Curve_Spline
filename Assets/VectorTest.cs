using UnityEngine;
using System.Collections;

public class VectorTest : MonoBehaviour
{

		void Start ()
		{
				Vector3 R = new Vector3 (1, 2, 3);
				float r = R.magnitude;
				Vector3 e = R.normalized;
				print ("ベクトル" + R + "長さ" + r + "単位ベクトル" + e);
				print ("元の長さの復元" + e * r);
		}
	
}
