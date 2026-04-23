using UnityEngine;

public class spawnObjectScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;

    private GameManagerScript gm;
    private float timer;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManagerScript").GetComponent<GameManagerScript>();

        rb = GetComponent<Rigidbody2D>();
    }

 
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >30)
        {
            Destroy(gameObject);
        }


        rb.linearVelocity = Vector2.left * (speed * gm.speedMultiplier); 
    }
}
