using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementLerper : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public FloatField speed;
    public BoolField move;
    private bool dirRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move.Value)
        {
        if (dirRight)
            transform.Translate(Vector3.right * speed.Value * Time.deltaTime);
        else
            transform.Translate(-Vector3.right * speed.Value * Time.deltaTime);

        if (transform.position.x >= 3.4)
        {
            dirRight = false;
        }

        if (transform.position.x <= .5f)
        {
            dirRight = true;
        }
        }
    }

 
}

