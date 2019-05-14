 using System;
 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 
 public class BGMusic : MonoBehaviour
 {
     public AudioSource BgMusic;
 
     public static GameObject bgmObject;
     // Start is called before the first frame update
     void Awake()
     {
         if (bgmObject)
         {
             Destroy(gameObject);
             return;
             
         }
         BgMusic.Play();
         bgmObject = gameObject;
     }


     // Update is called once per frame
     void Update()
     {
         Scene sn = SceneManager.GetActiveScene();
         if (sn.name == "GameScene")
         {
             BgMusic.Stop();
             Destroy(gameObject);
         }

     }
 }
