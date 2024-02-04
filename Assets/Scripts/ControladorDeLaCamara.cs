using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeLaCamara : MonoBehaviour
{
    public GameObject jugador;
    Vector3 distancia;

    void Start()
    {
        distancia = transform.position - jugador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      transform.position = jugador.transform.position + distancia ;
    }
}
