using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    public bool IsOn = false; 

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<PlayerMovement>() != null)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;

            IsOn = true;
        }
    }

}
