using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelect : MonoBehaviour
{
    private GameObject arrowLeft;
    private GameObject arrowRight;
    // Start is called before the first frame update
    void Start()
    {
        arrowLeft = GameObject.Find("Arrow-Left");
        arrowRight = GameObject.Find("Arrow-Right");

        if(SceneManager.GetActiveScene().name == "MenuSelect")
        {
            arrowLeft.SetActive(false);
        }
        if (SceneManager.GetActiveScene().name == "MenuSelect2")
        {
            arrowRight.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
