using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{

    private Transform myTransform;
    public float speed;

    bool follow;
    int minRange;
    Transform target;

    void Start()
    {

        GameObject player = GameObject.Find("Player");
        target = player.GetComponent<Transform>();

        minRange = 1;
        speed = 0.2f;
        //target = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);        
    }


    void Update()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.forward * speed);
    }

}
