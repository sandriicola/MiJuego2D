using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
public string clonBala;
float VelocidadEnemigo = 0.6f;
float DistanciaPlayer = 4f;
Vector3 PosicionOriginal;
public GameObject player;
public GameObject gestorSonido;
private AudioSource emisorEnemigo;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        PosicionOriginal = transform.position;
        emisorEnemigo = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Objetivo = PosicionOriginal;
        float Distancia = Vector3.Distance(player.transform.position, transform.position);
        if( Distancia < DistanciaPlayer){
            Objetivo = player.transform.position;
        }
        float Velocidad = VelocidadEnemigo*Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Objetivo, Velocidad);


    }
    void OnTriggerEnter2D(Collider2D otro){
        clonBala = otro.gameObject.name;
        if(clonBala == "BalaFuego(Clone)"){
            emisorEnemigo.PlayOneShot(gestorSonido.GetComponent<audioManager>().sonidoBola ,1f);
            principalScript.Enemigos -=1;
            Destroy(this.gameObject, 0.3f);

        }
        if (clonBala == "Personaje"){
            principalScript.Vida -=1;
            player.transform.position = new Vector3(0f,-0.4650001f,0f);
            gestorSonido.GetComponent<audioManager>().sonidoDead();

        }

    }
}
