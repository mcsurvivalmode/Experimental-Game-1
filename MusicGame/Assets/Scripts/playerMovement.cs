using Mono.Cecil.Cil;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    
    public float moveSpeed;
    float speedX, speedY;
    int Health = 5;
    public string sceneToLoad;

    public TMP_Text healthText;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
     
    }

   
    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed;
        rb.linearVelocity = new Vector2(speedX, speedY);

        if (Health ==0)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }


    void OnTriggerEnter2D (Collider2D col)
    {
        Health--;
        Debug.Log("HIT");
        healthText.text = "Health: " + Health.ToString ();

    }
}
