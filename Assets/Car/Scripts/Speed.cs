using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Speed : MonoBehaviour {
    public Text speedDisplay;
	
	// Update is called once per frame
	void Update () {
        Vector3 speed = gameObject.GetComponent<Rigidbody>().velocity;
        speed.y = 0;
        speedDisplay.text = "Speed: " + ((int)speed.magnitude).ToString();
	}

    
}
