using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitPlate : MonoBehaviour
{
    [SerializeField]
    GameManager gameManager;


    private float timer;

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                gameManager.exitPlate1 = false;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.GetComponent<PlayerMovement>() != null)
        {
            gameManager.exitPlate1 = true;
            timer = 1f;
        }
    }
}
