using UnityEngine;
using System.Collections;

public class AddF : MonoBehaviour
{
		public GameObject bulletPref;
		Transform _transform;

		void Start ()
		{
				_transform = transform;
				GameObject go = Instantiate (bulletPref, _transform.position, Quaternion.identity) as GameObject;
				//go.rigidbody.AddForce (2, 0, 0.0f, ForceMode.Impulse);	//質量が反映されて瞬間的に力を加えている
				go.rigidbody.AddForce (1, 0, 0.0f, ForceMode.Impulse);	//質量が反映されて瞬間的に力を加えている
		}
	
}
