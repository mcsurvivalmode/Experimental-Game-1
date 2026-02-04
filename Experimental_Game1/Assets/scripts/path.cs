using System.Collections;
using System.Drawing;

using System.Collections.Generic;
using UnityEngine;

public class path : MonoBehaviour
{
    [SerializeField]Transform[] Point;
    [SerializeField]private float moveSpeed;
    private int pointIndex;

    void Start()
    {
        transform.position = Point[pointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(pointIndex <= Point.Length - 1)
        {
            Debug.Log("run");
            transform.position = Vector2.MoveTowards(transform.position, Point[pointIndex].transform.position, moveSpeed * Time.deltaTime);

            if(transform.position == Point[pointIndex].transform.position)
            {
                pointIndex += 1;
            }

            if (pointIndex == Point.Length)
            {
                pointIndex = 0;
            }
        }
    }
}
