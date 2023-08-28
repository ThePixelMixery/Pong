using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioControl : MonoBehaviour
{
    public AudioMixer mixer_FX;

    public void SetLevel(float sliderValue)
    {
        mixer_FX.SetFloat("FX_Volume", Mathf.Log10(sliderValue) * 20);
    }
}
