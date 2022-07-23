using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLine : MonoBehaviour
{
    [SerializeField]
    private Timer timer;

    [SerializeField]
    private GameObject endGameText;

    [SerializeField]
    private PlayerMovement movement;

    [SerializeField]
    private CharacterController2D controller2D;

    bool gameHasEnded = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(gameHasEnded == false)
            {
                gameHasEnded = true;
                timer.enabled = false;
                movement.speed = 0f;
                controller2D.enabled = false;
                movement.enabled = false;
                

                //Debug.Log("game ove");
                Invoke("ToMain", 1f);
            }
            
        }
    }

    void ToMain()
    {
        SceneManager.LoadScene(0);
    }

}
