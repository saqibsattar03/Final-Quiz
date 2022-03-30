using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Text toDisplay;
	private int score;
	public Text scoreText;
	public Text timerText;
	private float secondsCount;
	private int minuteCount;
	private int hourCount;

	public static GameManager instance;

	void Awake()
	{
		//Static instance
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;

		}
		}

	private void Update()
	{
		GameTimer();
	}
	public void UpdateColor(string colorName) 
	{
		colorName = colorName.Substring(0, colorName.IndexOf("(") + 0);
		toDisplay.text = "C.Color:" + colorName.ToString();
	}

	public void ScoreUpdate(int s) 
	{
		score += s;
		scoreText.text = "Score:" + score.ToString("000");
	}

	void GameTimer() 
	{
		secondsCount += Time.deltaTime;
		timerText.text = hourCount + "h:" + minuteCount + "m:" + (int)secondsCount + "s";
		if (secondsCount >= 60)
		{
			minuteCount++;
			secondsCount %= 60;
		}
		if (minuteCount >= 60)
		{
			hourCount++;
			minuteCount %= 60;
		}
	}
}
