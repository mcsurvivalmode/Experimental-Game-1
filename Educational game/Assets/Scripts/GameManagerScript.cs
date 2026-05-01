using UnityEngine;
using UnityEngine.UI;


public class GameManagerScript : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public float timer;
    public float timeBetweenSp;

    public float speedMultiplier; 

    public GameObject[] spawnObject;

    public Text distanceUI;
    private float distance; 

    void Start()
    {
        
    }


    void Update()
    {
        distanceUI.text = "Score: " + distance.ToString("F2");
        distance += Time.deltaTime * 0.8f; 
        
        speedMultiplier += Time.deltaTime * 0.1f; 

        timer += Time.deltaTime;

        if(timer > timeBetweenSp)
        {
            timer = 0;
            int randNum = Random.Range(0, 3);
            Instantiate(spawnObject[randNum], spawnPoints[randNum].transform.position, Quaternion.identity);

        }
    }
}
