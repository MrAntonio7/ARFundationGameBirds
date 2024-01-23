using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject arCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void Disparo()
    {
        GameObject proyectil = Instantiate(bullet, arCam.transform.position, arCam.transform.rotation);
        proyectil.GetComponent<Rigidbody>().AddForce(arCam.transform.forward * 2000);
        GetComponent<AudioSource>().Play();
        Destroy(proyectil, 2f);
    }


    IEnumerator Esperar1s()
    {
        yield return new WaitForSeconds(1);
        //xro.textoPlano.gameObject.SetActive(false);
    }
}
