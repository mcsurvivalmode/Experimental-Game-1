using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
public class playerMovement : MonoBehaviour
{ 
		//VARIABLES
    	Rigidbody rb;
        public float speed;
		public float jumpforce;
		public GameObject click; //audio
		public GameObject Particle; // particle effect 
		private int baubleCount; //holds the amount of baubles the player has hit 
		public TMP_Text baubleCountText; //displays the amount of baubles hit 
		public TMP_Text completeText; // empty text on canvas that the script fills in 



		void OnCollisionEnter (Collision col)
	{
		//COLLISION
		if(col.gameObject.name == "bauble" && col.gameObject.GetComponent<counterScript>().isCounted == false)
		{
			//if the player hits another bauble AND it hasnt been counted...

			Instantiate (click); //these are both prefabs
			Instantiate(Particle);

			col.gameObject.GetComponent<Renderer>().material.color = Color.red; //changes the material colour
			 
			baubleCount++; //adds to the bauble count
			
			col.gameObject.GetComponent<counterScript> ().isCounted = true; //makes sure the baubles are only counted once
		
			setCountText (col.gameObject.name);
			complete(); //calls the text function
		}
		else if(col.gameObject.name == "bauble")
        {
			//if the player hits another bauble...
            Instantiate (click);
			Instantiate (Particle, transform.position, Quaternion.identity); //spawns the particle effect where the player is 
        }


	}

		void Update()
    {
        //RESTART
		//if player presses R the scene reloads!
		if(Input.GetKeyDown(KeyCode.R))
		{
			Application.LoadLevel(Application.loadedLevel);
		}
    }

    	void FixedUpdate () 
	{
		
		//MOVEMENT 
		//this gets the horizontal and vertical axis
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);


		rb.AddForce (movement * speed); // adding force to the rigid body by multipling the movement and speed 

		//JUMP
		//if (Input.GetKeyDown(KeyCode.Space))
		//{
            //rb.AddForce(Vector3.up * jumpforce);
		//}
		
	}

		void setCountText(string objectName)
	{	//updates the text on the canvas 

		if (objectName == "bauble") 
		{
			baubleCountText.text = "Count:" + baubleCount.ToString (); 
		}


	}

		void complete()
    { //when the player gets all 15 baubles the win text will appear 
        if (baubleCount >= 15) 
		{
			completeText.text = "Great Job! You got all 15 baubles!!!!";
		}
    }


}
