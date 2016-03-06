using UnityEngine;
using System.Collections;

public class DestroyEnemies: MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Enemy") {
			Destroy (col.gameObject);
		}

	}
}
