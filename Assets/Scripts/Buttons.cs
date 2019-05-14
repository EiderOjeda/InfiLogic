using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour    
{
    public string sceneName;
    public float finalXPosition;

    private Vector3 finalPosition;
    private float moveSpeed = 7.0f;

    public enum ButtonType { MainMenuButton, InGameButton, InGameButtonWithLoadScene};
    public ButtonType type;

    public bool EnableSlidingEffect = true;

    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        finalPosition = new Vector3(finalXPosition, transform.position.y, transform.position.z);
        startPosition = gameObject.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == finalPosition)
        {
            if((type==ButtonType.MainMenuButton) || (type == ButtonType.InGameButtonWithLoadScene))
                SceneManager.LoadScene(sceneName);
            else if (type == ButtonType.InGameButton)
            {

            }
        }
        
    }

    private void OnMouseDown()
    {
        if(EnableSlidingEffect== true)
        {
            finalPosition = new Vector3(finalXPosition, transform.position.y, transform.position.z);
            StartCoroutine(MoveToPosition(finalPosition));
        }
        if(type== ButtonType.InGameButtonWithLoadScene)
            GameManager.game_status.status = GameStatus.GameStat.start;
        

    }

    IEnumerator MoveToPosition(Vector3 targetPosition)
    {
        while(transform.position != targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            yield return 0;
        }
        if (type == ButtonType.MainMenuButton)
        {
            if (gameObject.name == "Exit")
            {
                Application.Quit();

            }

        }


        if (type == ButtonType.InGameButton)
        {
            if (gameObject.name == "Start")
            {
                Destroy(GameObject.FindGameObjectWithTag( "Tagline" ));
                Destroy(gameObject);
                
                GameManager.game_status.status = GameStatus.GameStat.start_pressed;
            }
            if (gameObject.name == "Menu")
            {
                if(transform.position != startPosition)
                {
                    StartCoroutine(MoveToPosition(startPosition));
                }
                GameManager.game_status.status = GameStatus.GameStat.inGameMenu;
            }
            if (gameObject.name == "Resume")
            {
                
                GameManager.game_status.status = GameStatus.GameStat.resume;
                transform.position = startPosition;
            }
            if (gameObject.name == "ChoosePicture")
            {
                
                
                transform.position = startPosition;
            }
        }
        
    }
}
