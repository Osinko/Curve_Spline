using UnityEngine;
using System.Collections;

public class Atan : MonoBehaviour
{
		void Start ()
		{
				print (Mathf.Cos (Mathf.Deg2Rad * 30));
				print (Mathf.Sin (Mathf.Deg2Rad * 30));
				print (Mathf.Sin (Mathf.Deg2Rad * 30) / Mathf.Cos (Mathf.Deg2Rad * 30));	//tan30°
				print (Mathf.Tan (Mathf.Deg2Rad * 30));

				Vector2 vec = Vector2.right;	//三角関数は数学的にX+が基準になる為、atanも例外ではない
				print (vec);
				vec = Quaternion.AngleAxis (30, Vector3.forward) * vec;	//クォータニオンの後にベクトルを掛ける（反対はエラーが出るので注意）
				print (vec);
				print (Mathf.Atan (vec.y / vec.x) * Mathf.Rad2Deg);
				print (Mathf.Atan2 (vec.y, vec.x) * Mathf.Rad2Deg);
				print (Mathf.Atan (Mathf.Sin (Mathf.Deg2Rad * 30) / Mathf.Cos (Mathf.Deg2Rad * 30)) * Mathf.Rad2Deg);	//tan30°
		}
}
