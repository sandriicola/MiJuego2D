using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoArma : MonoBehaviour
{
   public GameObject Bala;
   public GameObject gestorSonido;
   void Setup(){
    gestorSonido = GameObject.Find("AudioManager");
   }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) == true){
        Instantiate (Bala, new Vector2(transform.position.x, transform.position.y), transform.rotation);
        this.GetComponentInParent<AudioSource>().PlayOneShot(gestorSonido.GetComponent<audioManager>().lanzaBola,1f);

        }
    }
}
