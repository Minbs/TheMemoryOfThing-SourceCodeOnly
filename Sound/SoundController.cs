using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;
public class SoundController : MonoBehaviour
{
	public static SoundController Instance;
	public SoundManager soundManager;
	//[HideInInspector]
	public AudioClip[] uiClip;
	//[HideInInspector]
	public string[] uiClipName;
	//[HideInInspector]
	public AudioClip[] soundEffectClip;
	//[HideInInspector]
	public string[] soundEffectName;

	public AudioClip[] BackgroundMusicClip;
	//[HideInInspector]
	public string[] BackgroundMusicName;

	private void Awake()
	{
		if(!Instance)
		{
			Instance = this;
		}
	}

	private void Start()
	{
		uiClip = Resources.LoadAll<AudioClip>("Sound/UI/");
		uiClipName = new string[uiClip.Length];

		for (int i = 0; i < uiClip.Length; i++)
		{
			uiClipName[i] = uiClip[i].name.ToString();
		}

		soundEffectClip = Resources.LoadAll<AudioClip>("Sound/UI/");
		soundEffectName = new string[soundEffectClip.Length];

		for (int i = 0; i < soundEffectClip.Length; i++)
		{
			soundEffectName[i] = soundEffectClip[i].name.ToString();
		}

		BackgroundMusicClip = Resources.LoadAll<AudioClip>("Sound/Background/");
		BackgroundMusicName = new string[BackgroundMusicClip.Length];

		for (int i = 0; i < BackgroundMusicClip.Length; i++)
		{
			BackgroundMusicName[i] = BackgroundMusicClip[i].name.ToString();
		}

		PlayBackgroundMusic("MainTitle");
	}

	public void PlayUISound(string name)
	{
		int index = 0;

		for (int i = 0; i < uiClip.Length; i++)
		{
			if (name == uiClipName[i].ToString())
			{
				index = i;
			}
		}

		soundManager.PlayEffectsSound(uiClip[index]);
	}

	public void PlaySoundEffect(string name)
	{
		int index = 0;

		for (int i = 0; i < soundEffectClip.Length; i++)
		{
			if (name == soundEffectName[i].ToString())
			{
				index = i;
			}
		}

		soundManager.PlayEffectsSound(soundEffectClip[index]);
	}

	public void PlayBackgroundMusic(string name)
	{
		int index = 0;

		for (int i = 0; i < BackgroundMusicClip.Length; i++)
		{
			if (name == BackgroundMusicName[i].ToString())
			{
				index = i;
			}
		}

		soundManager.PlayBGMSound(BackgroundMusicClip[index]);
	}
}
