 using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BTNManager : MonoBehaviour
{
    public GameObject Canvas_MainMenu, Canvas_Counseling, Canvas_FadeInOut, Canvas_Option;

    public void BTN_Start()
    {
        Canvas_FadeInOut.SetActive(true);

		FadeInOut.instance.FadeAnimator.SetTrigger("FadeIn");

        StartCoroutine(delay());

	}

	public void BTN_Continue()
	{
		Canvas_FadeInOut.SetActive(true);

		FadeInOut.instance.FadeAnimator.SetTrigger("FadeIn");

		StartCoroutine(delay());
        if(GameManager.instance.LoadStageCount() != -999)
        {
            GameManager.instance.currentStageCount = GameManager.instance.LoadStageCount();
        }
		GameManager.instance.Init();
		GameManager.instance.PlayerTextStart();
	}

	IEnumerator delay()
    {
        yield return new WaitForSecondsRealtime(4.1f); // <= 타이머 시간 받아와야함
        Canvas_MainMenu.SetActive(false);
        Canvas_Counseling.SetActive(true);
		GameManager.instance.Init();
		GameManager.instance.PlayerTextStart();
		GameManager.instance.GuestTXT.text = "";
		GameManager.instance.PlayerTXT.text = "";
		DialogueHistory.instance.Clear();
	}
    
    public void BTN_OptionOn()
    {
        Canvas_Option.SetActive(true);
    }

    public void BTN_OptionBack()
    {
        Canvas_Option.SetActive(false);
    }

    public void BTN_Exit()
    {
        Application.Quit();
    }
}