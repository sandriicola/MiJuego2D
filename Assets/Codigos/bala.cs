using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Movimiento.direccionBala == true && Movimiento.parardireccionBala == false){
        transform.Translate (new Vector2 (Time.deltaTime * 7,0));
        }
        if(Movimiento.direccionBala == false && Movimiento.parardireccionBala == false){
            transform.Translate(new Vector2 (-Time.deltaTime * 7,0));
        }
    }
}
