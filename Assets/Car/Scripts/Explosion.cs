using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

    public GameObject explosion;
    public int speedAfterExplosion = 20;
	void OnCollisionEnter (Collision other)
    {
        Vector3 carVelocity = gameObject.GetComponent<Rigidbody>().velocity; 
        carVelocity.y = 0;
        carVelocity /= gameObject.GetComponent<Rigidbody>().velocity.magnitude;
        if (other.relativeVelocity.magnitude > 50 && other.gameObject.CompareTag("Car"))
        {
            if (other.gameObject.GetComponent<Rigidbody>().velocity.magnitude < GetComponent<Rigidbody>().velocity.magnitude)
            {
                Destroy(other.gameObject);
                
                
                               
                gameObject.GetComponent<Rigidbody>().velocity = carVelocity * speedAfterExplosion;
                Instantiate(explosion, other.transform.position, other.transform.rotation);
            }

        }
	}

    IEnumerator delay()
    {
        yield return new WaitForSeconds(.05f);
    }
}
