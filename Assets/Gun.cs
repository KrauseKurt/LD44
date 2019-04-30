using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject proj;

    private void Shoot()
    {
        GameObject obj = Instantiate(proj, this.transform.position, this.transform.rotation, this.transform);
        obj.transform.SetParent(null);
        obj.GetComponent<Projectile>().Launch();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
}
