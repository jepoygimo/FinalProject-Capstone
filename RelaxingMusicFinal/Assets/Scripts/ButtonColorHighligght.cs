using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorHighligght : MonoBehaviour
{
    //button variables
    Button btn;
    Image color;
    AudioSource MusicSource;

    //sliders variable
    public GameObject VolSlider;
    GameObject[] sliderList;

    //volumecontrol variables
    private AudioSource audioSrc;
    private float musicVolume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //buttons
        gameObject.AddComponent<AudioSource>();
        btn = gameObject.GetComponent<Button>();
        color = gameObject.GetComponent<Image>();
        MusicSource = gameObject.GetComponent<AudioSource>();
        MusicSource.clip = Resources.Load<AudioClip>(gameObject.name);
     
        btn.onClick.AddListener(PausePlayMusic);

        //sliders
        VolSlider = GameObject.Find(btn.gameObject.name + "Vol");
        sliderList = GameObject.FindGameObjectsWithTag("VolumeSliders");

        //volume control
        audioSrc = GetComponent<AudioSource>();
        
    }

    void PausePlayMusic()
    {
        if (!MusicSource.isPlaying)
        {
            MusicSource.Play();
            color.color = Color.cyan;

            foreach (var x in sliderList)
            {
                x.SetActive(false);
            }
            VolSlider.SetActive(true);
        }
        else
        {
            MusicSource.Pause();
            color.color = Color.white;

            foreach (var x in sliderList)
            {
                x.SetActive(false);
            }
            VolSlider.SetActive(false);
        }
    }

    private void Update()
    {
        audioSrc.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }

}
