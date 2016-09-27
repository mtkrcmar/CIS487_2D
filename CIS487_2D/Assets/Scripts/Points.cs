using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour {
	public static int points = 0;
	public static int Lvlpoints = 50;
	public UnityEngine.UI.Text pointsText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		pointsText.text = "Points: " + points;
	}
}
