using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorHighligght : MonoBehaviour
{
    Button btn;
    Image color;
    AudioSource MusicSource;
    //float speed = 0.1f;
    RectTransform btnSize;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        btn = gameObject.GetComponent<Button>();
        color = gameObject.GetComponent<Image>();
        MusicSource = gameObject.GetComponent<AudioSource>();
        MusicSource.clip = Resources.Load<AudioClip>(gameObject.name);
        //btnSize.gameObject.GetComponent<RectTransform>().anchorMax = new Vector2(1.25f, 1.25f);
        

        btn.onClick.AddListener(PausePlayMusic);

    }

    void PausePlayMusic()
    {
        if (!MusicSource.isPlaying)
        {
            MusicSource.Play();
            color.color = Color.cyan;
            
        }
        else
        {
            MusicSource.Pause();
            color.color = Color.white;
        }
    }

    
}
