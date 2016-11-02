using UnityEngine;
using System.Collections;

public class ClosePanel : MonoBehaviour {

    public GameObject menuPanel;

    // Use this for initialization
    void Start () {
        menuPanel = GameObject.FindGameObjectWithTag("UpgradePanel");
    }
    
    public void Close () {
        Debug.Log(string.Format("The upgrade panel is: {0}", menuPanel.ToString()));
        menuPanel.SetActive(false);
    }
}
