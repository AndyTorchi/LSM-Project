using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopkeepertext : MonoBehaviour
{
    [SerializeField]
    string popUp;


    bool playerInRange = false;

    GameObject player;

    [SerializeField]
    GameObject EKey;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player = collision.gameObject;
        playerInRange = true;
        EKey.SetActive(true);
        

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        playerInRange = false;
        EKey.SetActive(false);
    }

    private void Update()
    {
        if(playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            PopUpSystem pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopUpSystem>();
            pop.PopUp(popUp);

            player.gameObject.GetComponent<Model>().canMove = false;
            player.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
}
