using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scripDelAuto : MonoBehaviour
{
    bool perdiste;
    bool hasJump;
    float speed = 0.125f;  
    float jumpForce = 5f;
    Rigidbody rb;
    public Text txtTimeFloored;


    // Start is called before the first frame update
    void Start()
    {
        hasJump = true;
        perdiste = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (perdiste == false)
        {

            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, 0, speed);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, 0, -speed);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.eulerAngles += new Vector3(0, 3, 0);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.eulerAngles -= new Vector3(0, 3, 0);
            }

            if (Input.GetKeyDown(KeyCode.Space) && hasJump)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                hasJump = false;
            }
            float elapsedTime = Time.time;
            txtTimeFloored.text = Mathf.Floor(elapsedTime).ToString();
        }
                  
    }
    void OnCollisionEnter(Collision col)
    {
        if (perdiste == true)
        {
            SceneManager.LoadScene("escenaPerdiste");
        }
        //PERDISTE
        if (col.gameObject.name == "BONDI")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaPerdiste");

        }
        if (col.gameObject.name == "PALITO01")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaPerdiste");
        }
        if (col.gameObject.name == "PALITO02")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaPerdiste");
        }
        if (col.gameObject.name == "PALITO03")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaPerdiste");
        }
        if (col.gameObject.name == "PARED")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaPerdiste");
        }
        if (col.gameObject.name == "HUEVO")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaPerdiste");
        }
        if (col.gameObject.name == "HUEVO1")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaPerdiste");
        }
        if (col.gameObject.name == "HUEVO1")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaPerdiste");
        }
        if (col.gameObject.name == "CUBOROTADOR01S1")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaPerdiste");
        }
        if (col.gameObject.name == "CUBOROTADOR02S1")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaPerdiste");
        }
        if (col.gameObject.name == "CUBOROTADORS3")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaPerdiste");
        }
        if (col.gameObject.name == "CUBOROTADORS302")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaPerdiste");
        }
        if (col.gameObject.name == "CUBOROTADORS303")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaPerdiste");
        }
        if (col.gameObject.name == "CUBOROTADORS304")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaPerdiste");
        }
        if (col.gameObject.name == "CUBOROTADORS305")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaPerdiste");
        }
        if (col.gameObject.name == "CUBOROTADORS3007")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaPerdiste");
        }
        if (col.gameObject.name == "MURO")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaPerdiste");
        }
        if (col.gameObject.name == "MET4")
        {
            perdiste = true;
            SceneManager.LoadScene("escenaGanaste");
        }

        // CAMBIOS DE VELOCIDADES
        if (col.gameObject.name == "NAFTA")
        {
            speed = 0.03f;
        }
        if (col.gameObject.name == "AGUITA")
        {
            speed = 0.1f;
        }
        if (col.gameObject.name == "VELOCIDAD")
        {
            speed = 0.325f;
        }

        //PODER SALTAR O NO
        if (col.gameObject.name == "ROAD")
        {
            hasJump = true;
        }
        if (col.gameObject.name == "ANTISALTO")
        {
            speed = 0.275f;
            hasJump = false;
        }
        if (col.gameObject.name == "ROADsinfrenos")
        {
            perdiste = true;
        }
    }
}
