using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsGenerator : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnPoint;
    public bool canGenerate;
    private GameObject currentGeneratedBall;
    public GameObject Container;
    // Start is called before the first frame update
    private int counter;
    void OnEnable()
    {
    //    GenerateBall();

    }

  
    public void GenerateBall()
    {
        StartCoroutine(GenerateBallAfter());
    }
    public IEnumerator GenerateBallAfter()
    {
        yield return new WaitForSeconds(1);
        if (canGenerate)
        {
            currentGeneratedBall = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
            currentGeneratedBall.transform.SetParent(Container.transform);
        }
       
    }
}
