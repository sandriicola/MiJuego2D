using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public static float velocidad = 2f;
    public bool saltando = true; 
    public float salto = 5f;
    public Animator controlAnimacion;
    public static bool direccionBala = true;
    public static bool parardireccionBala = true;

    void Awake(){
        DontDestroyOnLoad(gameObject);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    
    {
        if(principalScript.Vida > 0){

        float movTeclas = Input.GetAxis("Horizontal")*velocidad;
        movTeclas *= Time.deltaTime;
        transform.Translate(movTeclas,0,0);
        //controles
        //Salto
        if(Input.GetKeyDown(KeyCode.Space) && saltando == false){
           GetComponent<Rigidbody2D> ().AddForce(new Vector2(0,salto),ForceMode2D.Impulse);
           saltando = true;
        }
        //direcciones
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)){
            transform.localScale = new Vector3(-1,1,1);
            controlAnimacion.SetBool("activacamina", true);
            direccionBala = false;
            Parallax.DireccionPersonaje = "izquierda";
            
        }
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)){
            transform.localScale = new Vector3(1,1,1);
            controlAnimacion.SetBool("activacamina", true);
            direccionBala = true;
            parardireccionBala = true;
            Parallax.DireccionPersonaje ="derecha";
        }
        if(Input.GetKeyUp(KeyCode.A)  || Input.GetKeyUp(KeyCode.LeftArrow) ){
            controlAnimacion.SetBool("activacamina", false);
            parardireccionBala = true; 
            Parallax.DireccionPersonaje = "parado";
        }
        if(Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow)){
             controlAnimacion.SetBool("activacamina", false);
            parardireccionBala = false; 
            Parallax.DireccionPersonaje = "parado";
        }
        }


    }
    void OnCollisionEnter2D(){
        saltando=false;
    }
}
