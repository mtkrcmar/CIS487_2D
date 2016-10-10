using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float thrust=50;
    public float sthrust=20;
    public static float downThrust=50;
    public static Rigidbody2D rb;
    public int boost=50;
    private bool isGasPressed = false;
    private bool isRightPressed = false;
    private bool isLeftPressed = false;
    private bool isLanded = true;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
        /*  if (isGasPressed) { //Uses Gas
              //rb.AddRelativeForce(Vector3.forward * thrust);
              rb.AddRelativeForce(transform.up*thrust);
              Gas.gasAmount = Gas.gasAmount - Gas.gasUsedAmount;
          }
          if (isRightPressed ) { 
              //rb.AddRelativeForce (transform.right * sthrust);
              transform.Rotate(Vector3.back * 90);
          }
          if (isLeftPressed ) {
              //rb.AddRelativeForce(transform.right * -sthrust);
              transform.Rotate(Vector3.forward);
          }

      */


        if (Input.GetKey ("space")) { //SpaceBar For Gas
            rb.AddRelativeForce(transform.up*thrust);
            Gas.gasAmount = Gas.gasAmount - Gas.gasUsedAmount;
        }
        if (Input.GetKey ("d") || Input.GetKey ("right")) { //D or Right Arrow for right
            //rb.AddRelativeForce (transform.right * sthrust);
            transform.Rotate(transform.forward * -1 * 2);

        }
        if (Input.GetKey ("a") || Input.GetKey ("left")) { // A or Left Arrow for left
            //rb.AddRelativeForce (transform.right * -sthrust);
            transform.Rotate(transform.forward * 2);

        }
        //S or Down arrow for Down once upgrade available
        if ((Input.GetKey ("s") || Input.GetKey ("down"))&&Upgrades.fallFasterUpgrade>0) {			
            rb.AddRelativeForce(transform.up*-thrust);
        }
    }

    public void OnPointerDownGasPressed()
    {
        isGasPressed = true;
    }
    public void OnPointerUpGasPressed()
    {
        isGasPressed = false;
    }

    public void OnPointerDownRightPressed()
    {
        isRightPressed = true;
    }
    public void OnPointerUpRightPressed()
    {
        isRightPressed = false;
    }

    public void OnPointerDownLeftPressed()
    {
        isLeftPressed = true;
    }
    public void OnPointerUpLeftPressed()
    {
        isLeftPressed = false;
    }
}
