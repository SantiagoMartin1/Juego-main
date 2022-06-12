using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSpawner : MonoBehaviour
{
    public GameObject HUEVO;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject capsule = Instantiate(HUEVO, transform.position, transform.rotation) as GameObject;
            capsule.name = "HUEVO";
            Destroy(capsule, 3f);
        }
    }
}
