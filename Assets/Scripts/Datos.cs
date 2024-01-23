using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Datos : MonoBehaviour
{
    public int puntos;
    public TextMeshProUGUI textoPuntos;
    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        textoPuntos.text = "Puntos: " + puntos; 
    }

    public void SumarPuntos(int numero)
    {
        puntos = puntos + numero;
    }

    public void RestarPuntos(int numero)
    {
        puntos = puntos - numero;
    }
}
