using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDelJugador : MonoBehaviour
{
    public float velocidad = 10;
    int monedas = 0;
    Rigidbody miRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        miRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        miRigidBody.AddForce(new Vector3(horizontal, 0, vertical) * velocidad);
    }

    void OnCollisionEnter(Collision otro)
    {
        if (otro.gameObject.CompareTag("wall"))
        {
            Debug.Log("Has Perdido, Por Nuv");
        } 

        else if( otro.gameObject.CompareTag("Finish"))
        {
            Debug.Log("Has salido, felicidades, Has Recogido " + monedas + " monedas");  
        }
        else if (otro.gameObject.CompareTag("moneda"))
        {
            otro.gameObject.SetActive(false);
            monedas = monedas + 1;
        }
    }
}
