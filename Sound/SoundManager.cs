using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
	public AudioClip[] bgmClipList;

	[SerializeField]
	public AudioSource bgmSource, effectsSource;

	private void Awake()
	{

	}

	private void Start()
	{
		bgmClipList = Resources.LoadAll<AudioClip>("Sound");
	}

	private void Update()
	{
	}

	public void PlayBGMSound(AudioClip clip)
	{
		bgmSource.clip = clip;
		bgmSource.loop = true;
		bgmSource.Play();
	}

	public void PlayEffectsSound(AudioClip clip)
	{
		effectsSource.clip = clip;
		effectsSource.loop = false;
		effectsSource.PlayOneShot(clip);
	}

	public void ChangeMasterVolume(float value)
	{
		AudioListener.volume = value;
	}

	public void ChangeBGMVolume(float value)
	{
		bgmSource.volume = value / 10000;
	}

	public void ChangeEffectsVolume(float value)
	{
		effectsSource.volume = value / 10000;
	}
}
