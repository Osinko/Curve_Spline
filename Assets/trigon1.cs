using UnityEngine;
using System.Collections;

public class trigon1 : MonoBehaviour
{
		void Start ()
		{
				float r, theta, x, y;
				r = 3.5f;
				theta = 30 * Mathf.Deg2Rad;	//°（単位度）からラジアンへ変換
				x = r * Mathf.Cos (theta);
				y = r * Mathf.Sin (theta);
				print ("r=" + r + " θ=" + theta + " x=" + x + " y=" + y);
		}
}
