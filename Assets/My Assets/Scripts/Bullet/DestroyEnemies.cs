using UnityEngine;
using System.Collections;

public class DestroyEnemies: MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }

        if (col.gameObject.tag == "Obstacles")
        {
            Destroy(this.gameObject);
        }
	}
}
