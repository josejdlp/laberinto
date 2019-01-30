using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controller : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }
 
    private void OnTriggerEnter(Collider other)
    {
        int x = (int)other.transform.position.x;
        int y = (int)other.transform.position.y;
        int z = (int)other.transform.position.z;

       Debug.Log("Entra x="+x+ " y=" + y+ " z="+ z);
        if((x==38 || x==37) && (z == 20 || z==21)) {
            GameObject.Find("Limite2").transform.position = new Vector3(43, 1, 21);
        }else if((x==36 || x==37|| x==38) && z ==17) {
            GameObject.Find("Limite1").transform.position = new Vector3(37, 0, 12);
        }

       
      //  Debug.Log("collide (name) : " + other.gameObject.name);
      //        Debug.Log("collide (tag) : " + other.gameObject.tag);

    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Sale");
        //GameObject.Find("MiCubo").transform.position = new Vector3(43, -5, 21);
    }


    public void CargarEscena (string escena) {
     Application.LoadLevel (escena);
 }
};
