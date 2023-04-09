using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class principalScript : MonoBehaviour
{
    public static int Score = 0;
    public static int Vida = 10;
    public static int Enemigos = 0;
    public GUISkin miSkin;
    public int AnchoPantalla;
    public Texture2D logoJuego;
    

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
        AnchoPantalla = Screen.width/2;
        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
        /*
        Debug.Log("Vida" + Vida);
        Debug.Log("Score" + Score);
        Debug.Log("Enemigos" + Enemigos);
        */
    }
    void OnGUI (){

        GUI.skin = miSkin; 
        GUI.Label(new Rect(20,20,150,80),"Vida: "+ Vida.ToString(),"estiloScore");
        GUI.Label(new Rect(100,20,150,80),"Score: "+ Score.ToString(),"estiloScore");
        GUI.Label(new Rect(180,20,150,80),"Enemigos: "+ Enemigos.ToString(),"estiloScore");
        GUI.Label(new Rect(AnchoPantalla-100,20,200,100),"JimmyTimmy", "estiloTitulo");

        GUI.DrawTexture(new Rect(Screen.width-120, 20, 80,80),logoJuego);
    }
}
