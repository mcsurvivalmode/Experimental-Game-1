using UnityEngine;
using System.Collections;

public class counterScript : MonoBehaviour {

	public bool isCounted;
	public GameObject click; //audio
	public GameObject Particle; // particle effect 

	// Use this for initialization
	void Start () {

		isCounted = false;
	
	}
	
void OnCollisionEnter (Collision col)
	{
		//COLLISION
		if(col.gameObject.name == "bauble")
        {
			//if the player hits another bauble...
            Instantiate (click);
			Instantiate (Particle, transform.position, Quaternion.identity); //spawns the particle effect where the player is 
        }


	}
}

