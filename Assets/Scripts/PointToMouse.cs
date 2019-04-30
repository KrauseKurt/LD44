using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToMouse : MonoBehaviour
{
    private void Update()
    {
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(this.transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
