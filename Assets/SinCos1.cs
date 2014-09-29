using UnityEngine;
using System.Collections;

public class SinCos1 : MonoBehaviour
{
		Vector2 vecA, vecB, tesB, VecAdditionTheorem, tesC;
		float alpha, beta;
		void Start ()
		{
				alpha = 30 * Mathf.Deg2Rad;
				beta = 42 * Mathf.Deg2Rad;
				//α位置の頂点を作成
				vecA = new Vector2 (Mathf.Cos (alpha), Mathf.Sin (alpha));

				//ここでvecAに単純に三角関数を加算してみる（これは正しい値にならない）
				tesB = new Vector2 (vecA.x + Mathf.Cos (beta), vecA.y + Mathf.Sin (beta));

				//こちらは本来あるべき位置の計算
				vecB = new Vector2 (Mathf.Cos (alpha + beta), Mathf.Sin (alpha + beta));

				//加法定理を使って計算
				VecAdditionTheorem = new Vector2 (vecA.x * Mathf.Cos (beta) - vecA.y * Mathf.Sin (beta),
		                                  vecA.y * Mathf.Cos (beta) + vecA.x * Mathf.Sin (beta));

				tesC = TrigonAdditionTheorem (vecA, 42 * Mathf.Deg2Rad);
		}

		/// <summary>
		/// 三角関数の加法定理の公式
		/// </summary>
		/// <returns>The addition theorem.</returns>
		/// <param name="alphaPosition">Alpha position.</param>
		/// <param name="betaRadian">Beta radian.</param>
		Vector2 TrigonAdditionTheorem (Vector2 alphaPosNorm, float betaRadian)
		{
				return new  Vector2 (alphaPosNorm.x * Mathf.Cos (betaRadian) - alphaPosNorm.y * Mathf.Sin (betaRadian),
		                     alphaPosNorm.y * Mathf.Cos (betaRadian) + alphaPosNorm.x * Mathf.Sin (betaRadian));
		}
}
