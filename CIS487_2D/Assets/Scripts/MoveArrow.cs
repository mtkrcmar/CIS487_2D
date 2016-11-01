using UnityEngine;
using System.Collections;

public class MoveArrow : MonoBehaviour {
	GameObject arrow;
	public Transform target;
	// Use this for initialization
	void Start () {
		arrow.SetActive (true);

	}
	
	// Update is called once per frame
	void Update () {
		
		transform.right = target.position - transform.position; // looks at whatever target is
	}
}
