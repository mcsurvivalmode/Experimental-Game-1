 using Mono.Cecil.Cil;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    private Camera mainCamera;

    //public float moveSpeed;
    //float speedX, speedY;
    int Health = 5;
    public string sceneToLoad;

    public TMP_Text healthText;
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
        Health--;
        Debug.Log("HIT");
        healthText.text = "Health: " + Health.ToString ();

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
