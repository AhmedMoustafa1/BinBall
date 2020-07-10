using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsContainer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.childCount>1)
        {
            Debug.Log(transform.childCount);
            Destroy(transform.GetChild(0).gameObject);
        }
    }
}
