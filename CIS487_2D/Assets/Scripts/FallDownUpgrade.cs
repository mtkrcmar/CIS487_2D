using UnityEngine;
using System.Collections;

public class FallDownUpgrade : MonoBehaviour {
	public UnityEngine.UI.Text fallUpgradeText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		fallUpgradeText.text = "Current Level: " + Upgrades.fallFasterUpgrade;
	}

	public void Clicked(){
		if(Coin.coinCount>=3){
			Coin.coinCount = Coin.coinCount - 3;	
		Upgrades.fallFasterUpgrade = Upgrades.fallFasterUpgrade + 1;
		if (Upgrades.fallFasterUpgrade > 1)
			Upgrades.fallFasterUpgrade = 2;
		}
	}
}
