using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciador : MonoBehaviour
{
    public GameObject huevo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Instantiate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(huevo, transform.position, transform.rotation);
        }
    }
}
