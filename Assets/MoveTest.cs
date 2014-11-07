using UnityEngine;
using System.Collections;

public class MoveTest : MonoBehaviour
{
		Transform _transform;
		Vector3 velocity;

		void Start ()
		{
				_transform = transform;
				velocity = new Vector3 (1, 1, 1);
		}
	
		void Update ()
		{
				_transform.Translate (velocity * Time.deltaTime);
		}
}
