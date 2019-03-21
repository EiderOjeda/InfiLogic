using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arrow : MonoBehaviour
{
    
    private void OnMouseDown()
    {
        if(gameObject.name== "Arrow-Left")
        {
            SceneManager.LoadScene("MenuSelect");
        }
        if (gameObject.name == "Arrow-Right")
        {
            SceneManager.LoadScene("MenuSelect2");
        }
    }
}
