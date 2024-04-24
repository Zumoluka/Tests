using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DispararProyectil : MonoBehaviour
{
    public GameObject prefabProyectil;

    private void DispararBala(Vector3 posicion, float velocidad)
    {
        GameObject proyectil = Instantiate(prefabProyectil, posicion, Quaternion.identity);
        Rigidbody rbProyectil = proyectil.GetComponent<Rigidbody>();
        rbProyectil.velocity = velocidad * transform.forward;
    }
}
