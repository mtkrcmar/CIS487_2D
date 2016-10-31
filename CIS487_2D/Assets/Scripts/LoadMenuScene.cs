using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadMenuScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Clicked () {
		Time.timeScale = 1; // unpause
		Gas.gasAmount = 100;//resetting static variables for restart
		SceneManager.LoadScene (1);
	}
}
