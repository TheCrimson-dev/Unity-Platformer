using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	public float enemySpeed;
	public float XmoveDirection;
	public float xMovedir = 0; 
    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(XmoveDirection, 0));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(XmoveDirection, 0) * enemySpeed;
        if (hit.distance < 0.1f)
        {
            Flip();
        }

    }


    void Flip() {
        if (XmoveDirection > 0)
        {
			XmoveDirection = -1 * xMovedir;
        }
        else {
			XmoveDirection = xMovedir; 
        }


    }
}
