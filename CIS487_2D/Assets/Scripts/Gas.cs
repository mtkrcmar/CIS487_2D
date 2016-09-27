using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Gas : MonoBehaviour {

	public static float gasAmount = 100f;
	public static float gasUsedAmount = .05f;
	public static float gasUsed;
	public static float gasPoints;
	public UnityEngine.UI.Text gasText;
	public UnityEngine.UI.Text gasPointsText;
	public UnityEngine.UI.Text gasUsedText;
	public static float multipler;
	// Use this for initialization
	void Start () {
		multipler = 1;
	}

	// Update is called once per frame
	void Update () {
		gasUsed = 100 - gasAmount;
		gasPoints = gasAmount * multipler;
		gasText.text = "Gas Amount: " + gasAmount.ToString("0") + "%";
		gasUsedText.text = "Gas Used: "+ gasUsed.ToString("0") + "%";
		gasPointsText.text = "Extra Gas Points: " + gasPoints.ToString("0");
		if (gasAmount < 0)
			gasAmount = 0;
	}
}
