using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeChange : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Slider BGMSlider, SFXSlider;

    public void SetBgmVolume()
    {
        float sound = BGMSlider.value;

        audioMixer.SetFloat("BGM", Mathf.Log10(sound) * 20);
    }

    public void SetSfxVolume()
    {
        float sound = SFXSlider.value;

        audioMixer.SetFloat("SFX", Mathf.Log10(sound) * 20);
    }
}
