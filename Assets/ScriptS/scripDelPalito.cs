using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripDelPalito : MonoBehaviour
{
    float timeToDoSomething;
    float timeToWait;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float currentTime = Time.time;

        if (currentTime > 2 )
        {
            transform.localScale = new Vector3(0.5f, 1.5f, 0.5f);
        }
        

    }
}
