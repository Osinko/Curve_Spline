using UnityEngine;
using System.Collections;

public class RationalNumber2 : MonoBehaviour
{
		Vector2 pos;
		Vector2 ans1, ans2, ans3;

		void Start ()
		{
				pos = new Vector2 (0, 250);
				ans1 = Trigonometric (pos);
				ans2 = Pythagoras (pos);
				ans3 = pos.normalized;
		}

		Vector2 Trigonometric (Vector2  pos)
		{
				float theta = Mathf.Atan2 (pos.y, pos.x);
				return new Vector2 (Mathf.Cos (theta), Mathf.Sin (theta));
		}

		Vector2 Pythagoras (Vector2 pos)
		{
				float unitCircle = Mathf.Sqrt (pos.x * pos.x + pos.y * pos.y);
				return new Vector2 (pos.x / unitCircle, pos.y / unitCircle);
		}
}
