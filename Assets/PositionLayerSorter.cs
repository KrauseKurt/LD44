using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionLayerSorter : MonoBehaviour
{
    public SpriteRenderer[] renderers;

    private void LateUpdate()
    {
        foreach(SpriteRenderer renderer in renderers)
        {
            renderer.sortingOrder = (int)(renderer.transform.position.y * -100);
        }
    }
}
