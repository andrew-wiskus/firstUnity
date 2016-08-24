using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour {
	private CountdownTimer countdownTimer;
	private Text textUI;
	private int fadeDuration = 5;
	private bool fading = false;
	// Use this for initialization
	void Start () {
		textUI = GetComponent<Text>();
		countdownTimer = GetComponent<CountdownTimer>();
		StartFading(fadeDuration);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (fading){
			float alphaRemaining = countdownTimer.GetProportionTimeRemaining();
			print (alphaRemaining);
			Color c = textUI.material.color;
			c.a = alphaRemaining;
			textUI.material.color = c;

			if (alphaRemaining < 0.01)
				fading = false;
		}
	}

	public void StartFading (int timerTotal){
		countdownTimer.ResetTimer(timerTotal);
		fading = true;
	}

		

}
