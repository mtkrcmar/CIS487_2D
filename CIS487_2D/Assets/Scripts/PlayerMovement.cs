using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public AudioSource gasSound;
    public GameObject fireAni;
    public float thrust=70;
    public float sthrust=20;
    public static float downThrust=50;
    public static Rigidbody2D rb;
    public int boost=50;
    private bool GasPressed = false;
    private bool isRightPressed = false;
    private bool isLeftPressed = false;
    private bool isLanded = true;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        fireAni.SetActive(false);

    }

    void FixedUpdate()
    {
        if (GasPressed)
        {
            //Check if not pointing at thr ground, then thrust normally.
            if (Vector3.Dot(transform.up, Vector3.down) > 0)
            {
                rb.AddRelativeForce(transform.up * -thrust + transform.right);
            }

            // If pointing at the ground, thrust downwards.
            else
            {
                rb.AddRelativeForce(transform.up * thrust + transform.right);
            }
        }


    }

    // Update is called once per frame
    void Update () {

        GasPressed = Input.GetKey("space");


        if (!GasPressed) {
            fireAni.SetActive(false);
            gasSound.Stop ();
        }

        if (GasPressed && Gas.gasAmount > 0){ //SpaceBar For Gas
           
            Gas.gasAmount = Gas.gasAmount - Gas.gasUsedAmount;
            fireAni.SetActive(true);

            if (gasSound.isPlaying) {
            }
            else {
                gasSound.Play ();
            }
            if (Gas.gasAmount <1) {
                thrust = 0;
                fireAni.SetActive(false);
                gasSound.Stop ();
            }

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

        Debug.Log (Upgrades.powerGasUpgrade );
        if (Upgrades.powerGasUpgrade == 1) {// level 1
            thrust= 1000;//from 70

        }
        if (Upgrades.powerGasUpgrade == 2) {// level 2
            thrust= 1500;
        }

    }

}
