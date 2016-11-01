using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExitToMainMenu : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
			Gas.gasAmount = 100;//reset gas
            SceneManager.LoadScene("MenuScene");
        }

    }
}
