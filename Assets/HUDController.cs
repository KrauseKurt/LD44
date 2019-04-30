using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public List<GameObject> Hearts = new List<GameObject>();

    public TextMeshProUGUI TxtCoins;
    public TextMeshProUGUI TxtWaveEnimies;
    public TextMeshProUGUI TxtPowerLevel;

    public Heart Heart;
    public Sprite[] ImgStatusHeart = new Sprite[4];

    public GameObject PanelHearts;

    /// <summary>
    /// Manager HUD hearts
    /// </summary>
    public void HeartsManager()
    {
        int heartObjectCount = PanelHearts.transform.childCount;
        float heartDivResult = GameController.Instance.Life % 4;

        // Full Heart
        if (heartDivResult == 0)
        {
            // Add
            if (heartObjectCount < (GameController.Instance.Life / 4))
            {
                Heart.ImgStatusHeart = ImgStatusHeart[(int)heartDivResult];
                GameObject a = (GameObject)Instantiate(Heart.gameObject);
                a.transform.SetParent(PanelHearts.transform, false);
            }
            else //Remove
            {
                Destroy(PanelHearts.transform.GetChild(heartObjectCount).gameObject);
            }

        }
        // 3/4 Heart
        else if (heartDivResult == 1)
        {
            Destroy(PanelHearts.transform.GetChild(heartObjectCount).
                GetComponent<Heart>().ImgStatusHeart = ImgStatusHeart[(int)heartDivResult]);
        }
        // 2/4 Heart
        else if (heartDivResult == 2)
        {
            Destroy(PanelHearts.transform.GetChild(heartObjectCount).
                GetComponent<Heart>().ImgStatusHeart = ImgStatusHeart[(int)heartDivResult]);
        }
        // 1/4 Heart
        else if (heartDivResult == 3)
        {
            Destroy(PanelHearts.transform.GetChild(heartObjectCount).
                GetComponent<Heart>().ImgStatusHeart = ImgStatusHeart[(int)heartDivResult]);
        }
    }
}