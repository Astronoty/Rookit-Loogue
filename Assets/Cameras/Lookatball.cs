using UnityEngine;
using System.Collections;

public class Lookatball : MonoBehaviour {
    public GameObject target;
    public GameObject car;
    private Vector3 directionToCar;
	// Use this for initialization
	
	// Update is called once per frame
	void Update ()
    {
        directionToCar = (car.transform.position - target.transform.position) / (car.transform.position - target.transform.position).magnitude;
        directionToCar *= ((car.transform.position - target.transform.position).magnitude + 5);
        transform.position = target.transform.position + directionToCar;
        transform.position += new Vector3(3, 2.5f, 0);
        if (transform.position.y <= 0)
            transform.position += new Vector3(0, 0 - transform.position.y + 1, 0);
        transform.LookAt(target.transform.position);


    }
}
