using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractPressurePlate : MonoBehaviour
{

    [SerializeField] private GameObject[] doorGameObject;
    private float timer;

    private bool isOpen = true;

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {

                isOpen = false;
                for (int i = 0; i < doorGameObject.Length; i++)
                {
                    doorGameObject[i].SetActive(false);

                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<PlayerMovement>() != null)
        {
            // Player entered collider!

            isOpen = true;
            for (int i = 0; i < doorGameObject.Length; i++)
                doorGameObject[i].SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.GetComponent<PlayerMovement>() != null)
        {
            // Player still on top of collider!
            timer = 1f;
        }
    }

}
