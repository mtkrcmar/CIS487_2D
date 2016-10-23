using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
	public CircleCollider2D coinEdge;
	public UnityEngine.UI.Text coinText;
	public GameObject coinObject;
	public static int coinCount=0;
	public AudioSource coinSoundFx;

	// Use this for initialization
	void Start () {
		coinEdge= GetComponent<CircleCollider2D>();
		coinEdge.enabled= true;
		coinObject.SetActive(true);

	}
	
	// Update is called once per frame
	void Update () {
		
		if (coinEdge.IsTouchingLayers()==true) {
			coinSoundFx.Play ();
			coinEdge.enabled= false;
			coinObject.SetActive(false);
			coinCount = coinCount + 1;

	}
		coinText.text = "Coins: " + coinCount;
}
}