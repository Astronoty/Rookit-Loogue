using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
 
    private int jumps;
    private float lastJumpTime;
    public float timeBetweenJumps = 10000f;
    public float rotateSensitivity = 1000000f;
    private float barrelRoll = 0f;
    public float rollFactor = 300f;
    public float jumpForce = 15000f;
    private Rigidbody carRigidbody;


    void Start()
    {
        carRigidbody = GetComponent<Rigidbody>();
        lastJumpTime = 0 - timeBetweenJumps;
    }
    bool OnGround()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1f);
    }
    void FixedUpdate ()
    {
        float h = Input.GetAxis("Horizontal") * rotateSensitivity * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * rotateSensitivity * Time.deltaTime;

        //Producing barrel roll

        if (Input.GetKey(KeyCode.E))
        {
            barrelRoll -= rollFactor;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            barrelRoll += rollFactor;
        }

        //Barrel roll drag effect
        if (barrelRoll < 0)
            barrelRoll += 100;
        else
            barrelRoll -= 100;

        //
        if (!OnGround())
        {
            carRigidbody.AddTorque(transform.up * h);
            carRigidbody.AddTorque(transform.right * v);
            carRigidbody.AddTorque(transform.forward * barrelRoll);
        }


        //Giving a double jump if car on ground and resetting barrel roll strength to 0
        if (OnGround())
        {
            jumps = 1;
            barrelRoll = 0f;

        }


        //Implementing jump
     
        if (Input.GetKeyDown(KeyCode.Space) && jumps > 0 && (Time.time >= (lastJumpTime + timeBetweenJumps)))
        {
            carRigidbody.AddForce(transform.up * jumpForce, ForceMode.Impulse);
            jumps--;

            if (Input.GetKey(KeyCode.E))
            {
                barrelRoll -= rollFactor*5;
            }

            if (Input.GetKey(KeyCode.Q))
            {
                barrelRoll += rollFactor*5;
            }
        } 

         
    }
}
