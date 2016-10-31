using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Clicked(){
		SceneManager.LoadScene (2);
	}
}
