using UnityEngine;
using System.Collections;


public class baubleSpin : MonoBehaviour
{

	// Rotate function
	public void Rotate(float rotationValue)
	{
		Debug.Log ("Rotate"+ rotationValue);
		//transform.Rotate(Vector3.up, rotationValue * Time.deltaTime);
		// Rotate arounf the Y axis using the rotation value
		transform.eulerAngles = new Vector3(0, rotationValue, 0);
	}

}