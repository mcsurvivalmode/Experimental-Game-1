using UnityEngine;

public class spawnObjectScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;

    private GameManagerScript gm;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManagerScript").GetComponent<GameManagerScript>();

        rb = GetComponent<Rigidbody2D>();
    }

 
    void Update()
    {



        rb.linearVelocity = Vector2.left * (speed * gm.speedMultiplier); 
    }
}
