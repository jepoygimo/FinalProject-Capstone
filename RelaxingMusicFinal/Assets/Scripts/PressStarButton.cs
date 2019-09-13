using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressStarButton : MonoBehaviour
{
    GameObject FrontPage;
    Button FPBtn;
    GameObject[] ListofSliders;
    // Start is called before the first frame update
    void Start()
    {
        FrontPage = GameObject.Find("FrontPage");
        FPBtn = gameObject.GetComponent<Button>();
        ListofSliders = GameObject.FindGameObjectsWithTag("VolumeSliders");

        FPBtn.onClick.AddListener(MovetoGame);
    }

    void MovetoGame()
    {
        foreach (var x in ListofSliders)
        {
            x.SetActive(false);
        }
        FrontPage.SetActive(false);
    }
}
