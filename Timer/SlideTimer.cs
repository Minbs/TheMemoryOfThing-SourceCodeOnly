using UnityEngine;
using UnityEngine.UI;

public class SlideTimer : MonoBehaviour
{
	[SerializeField] private Slider slideTimer;
	[SerializeField] private Image IMG_bar;
	public Gradient barColorGradient;

	private void Update()
	{
		timerLock();
		timeminus();
		barColorChange();
	}

	private void timerLock()
	{
		slideTimer.interactable = false;
	}

	private void timeminus()
	{
		if (GameManager.instance.gameState == GameState.Comment)
		{
			slideTimer.maxValue = GameManager.instance.StagesTimerData[GameManager.instance.currentStageCount];
			slideTimer.value = GameManager.instance.currentStageTimer;
		}
		else if (GameManager.instance.gameState == GameState.Question)
		{
			slideTimer.value = GameManager.instance.currentStageTimer;
		}
		else if(GameManager.instance.gameState == GameState.GameOver)
		{
			slideTimer.value = 0;
		}
	}

	private void barColorChange()
	{
		IMG_bar.color = barColorGradient.Evaluate(slideTimer.value / slideTimer.maxValue);

	}
}
