using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaInventario : MonoBehaviour
{
    private Dictionary<GameObject, int> inventario = new Dictionary<GameObject, int>();

    public void AgregarObjeto(GameObject objeto, int cantidad)
    {
        if (inventario.ContainsKey(objeto))
        {
            inventario[objeto] += cantidad;
        }
        else
        {
            inventario.Add(objeto, cantidad);
        }
    }

    public void QuitarObjeto(GameObject objeto, int cantidad)
    {
        if (inventario.ContainsKey(objeto))
        {
            inventario[objeto] -= cantidad;
            if (inventario[objeto] <= 0)
            {
                inventario.Remove(objeto);
            }
        }
    }
}
