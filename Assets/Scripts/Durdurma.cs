using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Durdurma : MonoBehaviour
{
CollisionHandler collisionHandler;
    //public bool oyunKontrolEt= true;
    float fixedDeltaTime;

    public GameObject canvas;
    public bool paused = true;
 
    void Start(){
        canvas.gameObject.SetActive (true);
        Time.timeScale = 0.0f;
        Cursor.visible = true;
        paused = true;
    }
 
    void Update () {
         if (Input.GetKeyDown(KeyCode.Escape)) {
             if(paused == true){
                 Time.timeScale = 1.0f;
                 canvas.gameObject.SetActive (false);
                 Cursor.visible = false;
                 paused = false;
                 Debug.Log("2.ife girdi calisti");
             } else {
                 Time.timeScale = 0.0f;
                 canvas.gameObject.SetActive (true);
                 Cursor.visible = true;
                 paused = true;
                 Debug.Log("ilk else burasi calisti");
             }
         }
         else{
           Debug.Log(" son else buraya giriyor mu kontrolu");


         }
     }
     
   
 

     
     
}