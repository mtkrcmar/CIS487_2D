using UnityEngine;
using System.Collections;

public class CloseUpgrade : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	


	}

	public void Clicked () {
		Time.timeScale = 1f; //unpause
		UpgradesWin.on = false;
 }
}