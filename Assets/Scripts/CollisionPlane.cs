using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using System;

public class CollisionPlane : MonoBehaviour
{
    private Datos datos;
    private GaneratePrefabs xro;
    private string tagActual;
    public GameObject efecto;
    // Start is called before the first frame update
    void Start()
    {
        datos = GameObject.FindGameObjectWithTag("Datos").GetComponent<Datos>();

        tagActual = gameObject.tag;

        xro = GameObject.FindGameObjectWithTag("xrOrigin").GetComponent<GaneratePrefabs>();

        Physics.gravity = new Vector3(0, -0.1f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.transform.tag == "Plane")
        {

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
            //xro.textoPlano.gameObject.SetActive(true);
            Destroy(this.gameObject);
            StartCoroutine(Esperar1s());
            
        }
        if (collision.transform.tag == "Bala")
        {

            switch (tagActual)
            {
                case "Blue":
                    datos.SumarPuntos(1);
                    break;

                case "Yellow":
                    datos.SumarPuntos(2);
                    break;
                case "Chicken":
                    datos.SumarPuntos(3);
                    break;
                case "Eagle":
                    datos.SumarPuntos(4);
                    break;
                case "Owl":
                    datos.SumarPuntos(5);
                    break;

                default:
                    Debug.LogWarning("Tag no reconocido: " + tagActual);
                    break;
            }
            //xro.textoBala.gameObject.SetActive(true);
            Destroy(this.gameObject);
            Destroy(collision.transform.gameObject);
            Vector3 posicionE = collision.contacts[0].point;
            GameObject e = Instantiate(efecto , posicionE, Quaternion.identity);
            Destroy(e, 2f);
            
            StartCoroutine(Esperar1sBala());
        }
    }
    IEnumerator Esperar1s()
    {
        yield return new WaitForSeconds(1);
        //xro.textoPlano.gameObject.SetActive(false);
    }
    IEnumerator Esperar1sBala()
    {
        yield return new WaitForSeconds(1);
        //xro.textoBala.gameObject.SetActive(false);
    }




}
