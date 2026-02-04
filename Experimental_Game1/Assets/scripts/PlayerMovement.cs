using System.Collections;

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 1f;
    

      // Update is called once per frame
    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));

        if (input.magnitude > 0 )
        {
            Vector2 movement = input.normalized * (movementSpeed * Time.deltaTime);
            transform.Translate(movement, Space.World);


            //float angle = Mathf.Atan2(input.y, input.x) * Mathf.Rad2Deg;
            //transform.rotation = Quaternion.Euler(0,0, angle);



        }



    }

    


}
