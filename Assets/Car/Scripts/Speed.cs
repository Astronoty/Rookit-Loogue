using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Speed : MonoBehaviour {
    public Text speedDisplay;
	
	// Update is called once per frame
	void Update () {
        speedDisplay.text = "Speed: " + ((int)gameObject.GetComponent<Rigidbody>().velocity.magnitude).ToString();
	}

    
}
