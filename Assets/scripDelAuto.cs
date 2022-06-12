﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scripDelAuto : MonoBehaviour
{
    public Text textoPerdiste;
    bool perdiste;
    bool hasJump;
    float speed = 0.125f;  
    float jumpForce = 8f;
    Rigidbody rb;

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
        }
                  
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "BONDI")
        {
            perdiste = true;
            textoPerdiste.text = "Perdiste pana";
        }
        if (col.gameObject.name == "bochaGanadora")
        {
            perdiste = true;
            textoPerdiste.text = "Ganaste, felicitaciones por ser tan inteligente";
        }
        if(col.gameObject.name == "PALITO01")
        {
            perdiste = true;
            textoPerdiste.text = "Perdiste pana";
        }
        if (col.gameObject.name == "PALITO02")
        {
            perdiste = true;
            textoPerdiste.text = "Perdiste pana";
        }
        if (col.gameObject.name == "PALITO03")
        {
            perdiste = true;
            textoPerdiste.text = "Perdiste pana";
        }
        if (col.gameObject.name == "PARED")
        {
            perdiste = true;
            textoPerdiste.text = "Perdiste pana";
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
    }
}