using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioControl : MonoBehaviour
{
    public AudioMixer mixer_master;

    public void SetMasterLevel(float sliderValue)
    {
        mixer_master.SetFloat("masterVolume", Mathf.Log10(sliderValue) * 20);
    }

    public void SetMusicLevel(float sliderValue)
    {
        mixer_master.SetFloat("musicVolume", Mathf.Log10(sliderValue) * 20);
    }

    public void SetFxLevel(float sliderValue)
    {
        mixer_master.SetFloat("fxVolume", Mathf.Log10(sliderValue) * 20);
    }
    
}
