using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveAudioMix : MonoBehaviour
{
    // Start is called before the first frame update
    private List<AudioClip> audioClipList;
    private AudioSource[] allAudioSources;
    private AudioSource[] allAudioSources2;
    Image[] btnColor;
    Button playsavebtn;
    GameObject[] x;
    GameObject[] SliderX;

    public void SaveMix()
    {
        audioClipList = new List<AudioClip>();
        allAudioSources2 = AudioSource.FindObjectsOfType<AudioSource>();        
        for (int i = 0; i < allAudioSources2.Length; i++)
        {
            if (allAudioSources2[i].isPlaying)
            {
                audioClipList.Add(allAudioSources2[i].clip);
            }
        }
       
        foreach (var x in audioClipList)
        {
            Debug.Log(x);
        }
                        
    }
    public void PlayMix()
    {
        playsavebtn = GameObject.Find("PlaySavedButton").GetComponent<Button>();
        for (int i = 0; i < audioClipList.Count; i++)
        {
            AudioSource.PlayClipAtPoint(audioClipList[i], new Vector3(0,0,-10));
        }
        playsavebtn.image.color = Color.yellow;
    }

    public void StopAllAudio()
    {
        btnColor = Image.FindObjectsOfType<Image>();
        allAudioSources = AudioSource.FindObjectsOfType<AudioSource>();

        for (int j = 0; j < btnColor.Length; j++)
        {
            if (btnColor[j].name == "Birds" || btnColor[j].name == "PlaySavedButton" ||btnColor[j].name == "Insects" ||btnColor[j].name == "Drums" ||btnColor[j].name == "Fire" ||btnColor[j].name == "Forest" ||btnColor[j].name == "Frog" ||btnColor[j].name == "Guitar" ||btnColor[j].name == "Heartbeat" ||btnColor[j].name == "HeavyRain" ||btnColor[j].name == "Humming" ||btnColor[j].name == "Whale" ||btnColor[j].name == "MonkChant" ||btnColor[j].name == "Night" ||btnColor[j].name == "Notes" ||btnColor[j].name == "Orchestra" ||btnColor[j].name == "Owl" ||btnColor[j].name == "Piano" ||btnColor[j].name == "Rain" ||btnColor[j].name == "River" ||btnColor[j].name == "Snow" ||btnColor[j].name == "Sun" ||btnColor[j].name == "Thunderstorm" ||btnColor[j].name == "Waterfall" ||btnColor[j].name == "Ocean" )
            {
                btnColor[j].color = Color.white;
            }
            
            
        }
        
        for (int i = 0; i < allAudioSources.Length; i++)
        {
            if (allAudioSources[i].isPlaying)
            {
                allAudioSources[i].Stop();
            }
        }

        x = GameObject.FindObjectsOfType<GameObject>();
        for (int a = 0; a < x.Length; a++)
        {
            if (x[a].name == "One shot audio")
            {
                Destroy(x[a]);
            }
        }

        SliderX = GameObject.FindGameObjectsWithTag("VolumeSliders");
        foreach (var x in SliderX)
        {
            x.SetActive(false);
        }


    }
}