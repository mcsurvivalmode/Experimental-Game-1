using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class playerMovement : MonoBehaviour
{
    public float jump;
    private Rigidbody2D rb;
    private bool isGrounded;
    private AudioSource source; 
    public AudioClip JumpSound;
    private int lives; 
    public Text livesUI;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        lives = 100; 
        source = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        livesUI.text = "Health: " + lives.ToString("F2");

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector2.up * jump);

            source.PlayOneShot(JumpSound, 1.0f);

        }

        if (lives <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

    
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("enemy"))
        {
            lives =-1; 
            //SceneManager.LoadScene(0);
        }
    }

}
