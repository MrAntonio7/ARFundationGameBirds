using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GaneratePrefabs : MonoBehaviour
{
    private string tagActual;
    float tiempoEntrePrefabs;
    public GameObject[] arrayEnemigos;
    public GameObject prefab;
    //private Vector3 posicionCamara;
    public GameObject arCam;
    private Datos datos;
    //public TextMeshProUGUI textoPlano;
    //public TextMeshProUGUI textoBala;
    // Start is called before the first frame update
    void Start()
    {
        datos = GameObject.FindGameObjectWithTag("Datos").GetComponent<Datos>();
        //Vector3 posicionCamara = arCam.transform.position;

        //textoPlano.gameObject.SetActive(false);
        //textoBala.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        tiempoEntrePrefabs-= Time.deltaTime;
        if(tiempoEntrePrefabs <= 0)
        {
            
            CrearObjecto();
            tiempoEntrePrefabs = Random.Range(1.5f, 2f);
        }
        
    }

    public void CrearObjecto()
    {
        int indiceAleatorio = Random.Range(0, arrayEnemigos.Length);
        Vector3 posicionOrigen = new Vector3( arCam.transform.position.x + Random.Range(-3, 3), arCam.transform.position.y + Random.Range(2, 3), arCam.transform.position.z + Random.Range(1, 3) );
        GameObject enemigo = Instantiate(arrayEnemigos[indiceAleatorio], posicionOrigen, Quaternion.identity);
        tagActual = enemigo.tag;
        switch (tagActual)
        {
            case "Blue":
                datos.RestarPuntos(1);
                break;

            case "Yellow":
                datos.RestarPuntos(2);
                break;
            case "Chicken":
                datos.RestarPuntos(3);
                break;
            case "Eagle":
                datos.RestarPuntos(4);
                break;
            case "Owl":
                datos.RestarPuntos(5);
                break;

            default:
                Debug.LogWarning("Tag no reconocido: " + tagActual);
                break;
        } 
        Destroy(enemigo, 10f);
        

        


    }

    IEnumerator Esperar1s()
    {
        yield return new WaitForSeconds(1);
        //xro.textoPlano.gameObject.SetActive(false);
    }

}
