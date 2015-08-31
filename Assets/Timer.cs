using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour
{
		public float time;

		void FixedUpdate ()
		{
				if (Time.timeSinceLevelLoad >= time) {
						rigidbody.Sleep ();
				}
		}
}
