using UnityEngine;
using System.Collections;

public class PowerGasUpgrade : MonoBehaviour {
	public UnityEngine.UI.Text powerGasUpgradeText;

	// Use this for initialization
	void Start () {
		powerGasUpgradeText.text = "Current Level: " + Upgrades.powerGasUpgrade;
	
	}
	
	// Update is called once per frame
	void Update () {
		powerGasUpgradeText.text = "Current Level: " + Upgrades.powerGasUpgrade;

	}

	public void Clicked(){
		if(Coin.coinCount>=10){
			
			Coin.coinCount = Coin.coinCount - 10;	
			Upgrades.powerGasUpgrade = Upgrades.powerGasUpgrade + 1;

			if (Upgrades.powerGasUpgrade > 1)
				Upgrades.powerGasUpgrade = 2;
		}
	}
}
