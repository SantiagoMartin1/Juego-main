using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner02Script : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 2; i++)
            {
                GameObject huevillo = Instantiate(prefab, transform.position, transform.rotation) as GameObject;
                huevillo.name = "HUEVO1";
                Destroy(huevillo, 3f);
            }

        }
    }
}
