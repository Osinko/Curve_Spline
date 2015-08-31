using UnityEngine;
using System.Collections;

public class Trigon3 : MonoBehaviour
{
		float theta, x, y, tan, arctan, arctan2;
		void Start ()
		{
				theta = 30f * Mathf.Deg2Rad;
				x = Mathf.Cos (theta);
				y = Mathf.Sin (theta);
				tan = Mathf.Tan (theta);
				arctan = Mathf.Atan (tan) * Mathf.Rad2Deg;
				arctan2 = Mathf.Atan2 (y, x) * Mathf.Rad2Deg;
				print ("cos=" + x + "  sin=" + y + "  tan=" + tan + "  arctan=" + arctan + "  arctan2=" + arctan2);

				Vector2 vec = Vector2.right;
				vec = Quaternion.AngleAxis (30, Vector3.forward) * vec;
				print ("30°回転させたベクトル=" + vec + "  arctan関数で逆算した値=" + Mathf.Atan2 (vec.y, vec.x) * Mathf.Rad2Deg);
		}
}
