using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using LitJson;


public class Tiempo : MonoBehaviour
{
    private List<Gamer> gamers=new List<Gamer>();
    public Text timerText;
    private float startTime;
    // Start is called before the first frame update
    void Start()    
    {
        startTime=Time.time;
        /* Gamer jugador1 = new Gamer("jose", 27, 125, 0, 0);
         Gamer jugador2 = new Gamer("manuel", 27, 128, 206, 0);
         Gamer jugador3 = new Gamer("pepito", 18, 89, 0, 0);
         gamers.Add(jugador1);
         gamers.Add(jugador2);
         gamers.Add(jugador3);
         */
        

        /*List<int> l = new List<int>();
            l.Add(133);
            l.Add(234);
        List<Puntuation> lp = new List<Puntuation>();
        lp.Add(new Puntuation(122, System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")));
        lp.Add(new Puntuation(222, System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")));

        List<Puntuation> lp2 = new List<Puntuation>();
        lp2.Add(new Puntuation(777, System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")));

        List<Puntuation> lp3 = new List<Puntuation>();
        lp3.Add(new Puntuation(888, System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")));

        Gamer jugadorx = new Gamer("jose", 27,lp,lp2,lp3);

        gamers.Add(jugadorx);*/

        //SaveJSON();
        LoadJson();
    }

   
    void Update()
    {
        //Cronómetro
        float t=Time.time-startTime;
        string minutes=((int) t/60).ToString();
        string second=(t%60).ToString("f0");
        timerText.text=minutes+":"+second;

   }

    //Guarda la información de los jugadores en un fichero json
    void SaveJSON() {
        JsonData jsondata = JsonMapper.ToJson(gamers);
        File.WriteAllText("gamers.json", jsondata.ToString());
        Debug.Log("Save"+gamers.Count);
    
    }

   

    //Carga en la lista de jugadores la información almacenada en el fichero json

    void LoadJson()
    {
        string jsonstring = File.ReadAllText("gamers.json");
        JsonData itemdata;
        itemdata = JsonMapper.ToObject(jsonstring);
        gamers.Clear();
      
           
            for (int i = 0; i < itemdata.Count; i++)
            {
                Gamer j=new Gamer();
                j.setName(itemdata[i]["name"].ToString());
                j.setAge((int)itemdata[i]["age"]);
                Debug.Log("Jugador:" + itemdata[i]["name"].ToString());

                for(int x=0; x < itemdata[i]["l1"].Count; x++) {
                    Debug.Log("Puntuaciones" + itemdata[i]["l1"][x]["time"].ToString());
                    j.addL1((int)itemdata[i]["l1"][x]["time"], itemdata[i]["l1"][x]["date"].ToString());
                }

                for (int x = 0; x < itemdata[i]["l2"].Count; x++)
                {
                    Debug.Log("Puntuaciones 2" + itemdata[i]["l2"][x]["time"].ToString());
                    j.addL2((int)itemdata[i]["l2"][x]["time"], itemdata[i]["l2"][x]["date"].ToString());
                }

                for (int x = 0; x < itemdata[i]["l3"].Count; x++)
                {
                    Debug.Log("Puntuaciones 3" + itemdata[i]["l3"][x]["time"].ToString());
                    j.addL3((int)itemdata[i]["l3"][x]["time"], itemdata[i]["l3"][x]["date"].ToString());
                }

                gamers.Add(j);
            
        }


      




            //Debug.Log("**Load" + itemdata[i]["l1"][0]["time"]);
            List<Puntuation> l1 = new List<Puntuation>();
         
            // Gamer j = new Gamer(itemdata[i]["name"].ToString(), (int)itemdata[i]["age"], (List)itemdata[i]["l1"],
            //           (int)itemdata[i]["l1"], (int)itemdata[i]["l3"]);
            //gamers.Add(j);
         
        Debug.Log("GAMERS" + gamers.Count);
        for (int z = 0; z< gamers.Count; z++)
        {
            Debug.Log(gamers[z].name);
            for(int t = 0; t < gamers[z].l1.Count; t++) {
                Debug.Log("PUNTUACIONeS" + gamers[z].l1[t].time);
            }

            Debug.Log(gamers[z].name);
            for (int w = 0; w < gamers[z].l2.Count; w++)
            {
                Debug.Log("PUNTUACIONeS" + gamers[z].l2[w].time);
            }
        }
    }
   }
