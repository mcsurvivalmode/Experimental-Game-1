using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    private Camera mainCamera;

    //public float moveSpeed;
    //float speedX, speedY;
    int Health = 0;
    public string sceneToLoad;

    public TMP_Text healthText;
    public TMP_Text ScoreText;
    public GameObject Particle;
    //Rigidbody2D rb;
    [SerializeField]
    private float maxSpeed = 10f;

    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
    }

   
    void Update()
    {
        //speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        //speedY = Input.GetAxisRaw("Vertical") * moveSpeed;
        //rb.linearVelocity = new Vector2(speedX, speedY);
        FollowMousePosition();
       
    }


    void OnTriggerEnter2D (Collider2D col)
    {
        Health++;
        Debug.Log("HIT");
        healthText.text = "HITS: " + Health.ToString ();
        ScoreText.text = "YOU SCORED: " + Health.ToString ();
        Instantiate (Particle, transform.position, Quaternion.identity);

    }

    private void FollowMousePosition()
    {
        transform.position = GetWorldPositionFromMouse();
    }

    private Vector2 GetWorldPositionFromMouse()
    {
        return mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }
}
