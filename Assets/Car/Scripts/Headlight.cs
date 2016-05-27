using UnityEngine;
using System.Collections;

public class Headlight : MonoBehaviour {
    public GameObject Light1;
    public GameObject Light2;
    bool lightsOn = false;
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.L))
            lightsOn = !lightsOn;

        Light1.SetActive(lightsOn);
        Light2.SetActive(lightsOn);
    }

}
