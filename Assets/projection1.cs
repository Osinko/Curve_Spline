using UnityEngine;
using System.Collections;

public class projection1 : MonoBehaviour
{
		Vector3 a, b, proj, proj2;

		void Start ()
		{
				a = new Vector3 (10, 4);
				b = new Vector3 (3, 7);

				proj = Vector3.Project (b, a);
				proj2 = a * (Vector3.Dot (a, b) / Vector3.Dot (a, a));

				print ("正射影unity標準機能＝" + proj + "  正射影自分で計算＝" + proj2);
		}
}
