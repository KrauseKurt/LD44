using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void Update()
    {
        this.transform.position += this.transform.position + Vector3.forward;
    }
}
