using UnityEngine;
using System.Collections;

public class Disrespect : MonoBehaviour {
    public GameObject airHorn;

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F))
            Instantiate(airHorn, gameObject.transform.position, gameObject.transform.rotation);
    }
}
