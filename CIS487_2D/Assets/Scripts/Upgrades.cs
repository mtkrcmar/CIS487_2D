using UnityEngine;
using System.Collections;

public class Upgrades : MonoBehaviour {

	public static int fallFasterUpgrade =0;
	public static int lessGasUpgrade =0;
	public static int powerGasUpgrade =0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (fallFasterUpgrade == 1) {// level 1
			
			PlayerMovement.downThrust = 50;
		}
		if (fallFasterUpgrade == 2) {// level 2
			PlayerMovement.downThrust = 100;
		}
		if (lessGasUpgrade == 1) {// level 1
			
			Gas.gasUsedAmount =.03f; //from.05
		}
		if (lessGasUpgrade == 2) {// level 2
			Gas.gasUsedAmount =.015f;
		}
	  //Powerfull gas upgrade in playermovement script



	}
}
