using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rbody;
    public float speed;
    private bool canMove = false;

    public void Launch()
    {
        canMove = true;
        rbody = GetComponent<Rigidbody2D>();
        rbody.AddRelativeForce(Vector3.right * speed);
        //rbody.velocity = Vector2.left;
        Destroy(this.gameObject, 3f);
    }

    
}
