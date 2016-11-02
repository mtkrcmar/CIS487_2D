using UnityEngine;
using System.Collections;

public class Crash : MonoBehaviour {
    private GameObject panel;
    private BoxCollider2D MyCollider;
    // Use this for initialization
    void Start () {
        MyCollider = GetComponent<BoxCollider2D>();
        panel = GameObject.Find("LosePanel");
        MyCollider.enabled= true;
    }
    
    // Update is called once per frame
    void Update () {
        if(MyCollider.IsTouching(GameObject.FindGameObjectWithTag("Player").GetComponent<BoxCollider2D>())){
            panel.SetActive (true);
            Time.timeScale = 0;//pause
    }
}
}
