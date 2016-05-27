using UnityEngine;
using System.Collections;

public class Lookatball : MonoBehaviour {
    public GameObject target;
    public GameObject car;
    private Vector3 directionToCar;
	// Use this for initialization
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        directionToCar = (car.transform.position - target.transform.position) / (car.transform.position - target.transform.position).magnitude;
        directionToCar *= ((car.transform.position - target.transform.position).magnitude + 5);
        transform.position = target.transform.position + directionToCar;
        transform.position += new Vector3(3, 2.5f, 0);
        transform.LookAt(target.transform.position);


    }
}
