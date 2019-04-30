using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rbody;
    private Vector3 vecvec;
    private Vector3 mouseVector;

    public GameObject gun;
    public GameObject projectile;
    public float bilubilu;
    public float speed = 1;
    public SpriteRenderer spr;


    public int Life = 3;

    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        GameController.Instance.Life = Life;
    }

    private void Update()
    {
        DirectionFacing();

        //Shooting
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

        Vector2 movementVec = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if(movementVec != Vector2.zero)
        {

        }
        else
        {

        }

        rbody.MovePosition(rbody.position + movementVec * Time.deltaTime * speed);


    }

    private void Shoot()
    {
        GameObject obj = Instantiate(projectile,gun.transform.position,gun.transform.rotation,gun.transform);
        GameController.Instance.DecLife();
        GameController.Instance.Hud.HeartsManager();
    }

    private void DirectionFacing()
    {
        mouseVector = Input.mousePosition;
        vecvec = (Camera.main.WorldToScreenPoint(this.transform.position) - mouseVector) * -1;
        bilubilu = vecvec.x;

        if (bilubilu > 0)
        {
            spr.flipX = false;
        }
        else
        {
            spr.flipX = true;
        }
    }

}
