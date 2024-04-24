using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] Rigidbody rb;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] public int score;
    public GameObject objetoRecogido;
    public int cantidadRecogida = 1;
    private SistemaInventario inventario;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        inventario = GetComponent<SistemaInventario>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(direction * force, ForceMode.Force);
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            Destroy(other.gameObject);
            Debug.Log("Agarraste un item");
            score++;
            scoreText.text = score.ToString();
            inventario.AgregarObjeto(objetoRecogido, cantidadRecogida);
        }
    }

}
