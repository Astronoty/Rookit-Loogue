using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Boost : MonoBehaviour {
    private int boost = 100;
    public float forceMagnitude = 50f;
    public Text boostText;
    
    public int boostDecrease = 1;
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (Input.GetKey(KeyCode.LeftShift) && boost > 0) 
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * forceMagnitude, ForceMode.Acceleration);
            boost -= boostDecrease;
        }

        boostText.text = "Boost: "+ boost.ToString();

	}
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Capsule"))
        {
            Destroy(other.gameObject);
            boost += 50;

            if (boost > 100)
                boost = 100;
        }

    }
    
}
