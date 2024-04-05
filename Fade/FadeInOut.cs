using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    public static FadeInOut instance;

    public Image Image_Guest;
    public Image Image_Panel;

    public BTNManager ButtonManager;

    public Animator FadeAnimator;

	public void Awake()
	{
		if(!instance)
        {
            instance = this;
        }
	}

	public void FadeOutStart()
    {
        FadeAnimator.SetTrigger("FadeOut");
    }

    public void FadeLoadingStart()
    {
        FadeAnimator.SetTrigger("FadeLoading");
        ButtonManager.Canvas_MainMenu.SetActive(false);
        ButtonManager.Canvas_Counseling.SetActive(true);
    }

    public void FadeLoadingText()
    {
        FadeAnimator.SetTrigger("FadeLoadingText");
    }

    public void StageStart()
    {
        SoundController.Instance.PlaySoundEffect("BellSound");
    }
}
