using UnityEngine;
using System.Collections;


public class Land : MonoBehaviour {
	public EdgeCollider2D baseEdge;
	public EdgeCollider2D playerEdge;
	public UnityEngine.UI.Text coinText;
	public Animator animator;
	public Sprite player;
	public bool endLvl = false;
	public GameObject playerLander;

	public GameObject panel;
	// Use this for initialization
	void Start () {
		Time.timeScale = 1; 
		baseEdge = GetComponent<EdgeCollider2D>();
		playerEdge= GetComponent<EdgeCollider2D>();
		animator = GetComponent<Animator> ();
		//player = GetComponent<Sprite> ();
		baseEdge.enabled= true;
		playerEdge.enabled= true;
		 
	}
	
	// Update is called once per frame
	void Update () {
		if (baseEdge.IsTouchingLayers()==true) { 
			animator.Stop ();
			panel.SetActive (true); // opens Win window
			PlayerMovement.rb.velocity = Vector2.zero;
			PlayerMovement.rb.velocity = Vector3.zero;
			if (endLvl == false) {
				Points.points = Points.points + Points.Lvlpoints+(int)System.Math.Round(Gas.gasPoints);
				endLvl = true;
				Time.timeScale = 0; // pause
			}
		}
	}
}
