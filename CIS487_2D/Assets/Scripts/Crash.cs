using UnityEngine;
using System.Collections;

public class Crash : MonoBehaviour {
	public EdgeCollider2D bottomEdge;
	public GameObject panel;
	// Use this for initialization
	void Start () {
		bottomEdge = GetComponent<EdgeCollider2D>();
		bottomEdge.enabled= true;
	}
	
	// Update is called once per frame
	void Update () {
		if(bottomEdge.IsTouchingLayers()){
			panel.SetActive (true);
			Time.timeScale = 0;//pause
	}
}
}
