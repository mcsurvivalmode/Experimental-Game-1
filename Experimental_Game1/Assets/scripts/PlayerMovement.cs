using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayerMovement : MonoBehaviour
{

    void Update()
    {
        //move the character 
        transform.Translate(Input.GetAxis("Horizontal")* 10f * Time.deltaTime, 0f, 0f );

        //flip the character 
        Vector2 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal")< 0)
        {
            characterScale.x = 1;

        }
           if (Input.GetAxis("Horizontal")> 0)
        {
            characterScale.x = -1;
            
        }
        transform.localScale = characterScale;


    }
    


    


}
