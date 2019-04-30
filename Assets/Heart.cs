using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{ 
    public Sprite ImgStatusHeart {
        get {
            return GetComponent<Image>().sprite;
        }
        // Set value in component image
        set
        {
            GetComponent<Image>().sprite = ImgStatusHeart;
        }
    }

    private void Start()
    {
        GetComponent<Image>().sprite = ImgStatusHeart;
    }
}