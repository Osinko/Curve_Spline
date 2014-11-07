using UnityEngine;
using System.Collections;

public class RationalNumber1 : MonoBehaviour
{
		Vector2 vecA = new Vector2 (113, 355);
		Vector2 vecB = new Vector2 (106, 333);

		float ratioA, ratioB, ans;
		float ans2;

		void Start ()
		{
				ratioA = vecA.y / vecA.x;
				ratioB = vecB.y / vecB.x;
				ans = ratioA - ratioB;		//実数に戻した計算

				ans2 = Ratio (vecA, vecB);

				print (ans);
				print (ans2);
		}

		//ベクトルを有理数に見立てて通分して計算
		float Ratio (Vector2 vecA, Vector2 vecB)
		{
				float numerator = (vecA.y * vecB.x) - (vecB.y * vecA.x);	//分子
				float denominator = (vecA.x * vecB.x);						//分母
				return numerator / denominator;
		}
}
