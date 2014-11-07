using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Line2))]
public class TestInspecter : Editor
{
		void OnSceneGUI ()
		{
				Line2 line = target as Line2;
				Handles.color = Color.white;
				Vector2 vecA = new Vector2 (1, 2);
				Vector2 vecB = new Vector2 (5, 8);
				//y1-y2=m*(x1-x2) の2頂点と傾きから直線を描く一次方程式の公式
				//m=(y1-y2)/(x1-x2)　上記の公式を傾きを求める式に変形。以下のmの式はそれを利用している
				float m = (vecB.y - vecA.y) / (vecB.x - vecA.x);
				Handles.DrawLine (vecA, vecB);
				
				float theta = Mathf.Atan (m);
				Vector2 vecC = new Vector2 (Mathf.Cos (theta), Mathf.Sin (theta));
				Handles.color = Color.red;
				Handles.DrawLine (Vector2.zero, vecC * 10);
				//赤線はアークタンジェントと傾きで求めたライン
		}
}
