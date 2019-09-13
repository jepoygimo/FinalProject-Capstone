using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderControl : MonoBehaviour
{
    public GameObject VolSlider;
    GameObject[] sliderList;
    //public GameObject x;
    // Start is called before the first frame update
    void Start()
    {
        VolSlider = GameObject.Find("BirdsVol");
        VolSlider.SetActive(true);
        
        //Hide all Volume Sliders
        sliderList = GameObject.FindGameObjectsWithTag("VolumeSliders");
        foreach (var x in sliderList)
        {
            x.SetActive(false);
        }
                
    }

    
}
