using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public GameObject Personaje;
    public GameObject gestorSonido;
    private static int contadorTrigger;
    

    // Start is called before the first frame update
    void Start()
    {
        contadorTrigger = 0;
        //Personaje = find("Personaje");
        //Personaje = Find.GameObject("Personaje");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(contadorTrigger);
    }
    void OnTriggerEnter2D (Collider2D otro) {
        if(contadorTrigger <= 0){
            Debug.Log("EfectoEco");
            contadorTrigger++;
        }else if (contadorTrigger >= 1){
            Debug.Log("has morido");
         //gestorSonido.GetComponent<AudioSource>().PlayOneShot(gestorSonido.GetComponent<audioManager>().sonidoMuerte,1f);
         gestorSonido.GetComponent<audioManager>().sonidoDead();
         principalScript.Vida -= 1;
         Personaje.transform.position = new Vector3(0f,-0.4650001f,0f);
         contadorTrigger++;
         }
         
    }
    void OnTriggerExit2D (){
        contadorTrigger--;
    }

}
