using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsGenerator : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnPoint;
    private GameObject currentGeneratedBall;
    // Start is called before the first frame update
    void Start()
    {
        GenerateBall();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Ground")) 
        {
            GenerateBall();
        }
    }

    public void GenerateBall()
    {
        currentGeneratedBall = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
    }
}
