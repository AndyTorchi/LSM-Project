using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MannequinBuy : MonoBehaviour
{
    [SerializeField]
    int SkinCode;

    [SerializeField]
    int BuyPrice;

    [SerializeField]
    int SellPrice;

    bool canBuy = false;

    [SerializeField]
    Canvas priceCanvas;

    [SerializeField]

    GameObject Player;

    [SerializeField]
    TMP_Text priceText;

    [SerializeField]
    TMP_Text sellText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canBuy = true;
        Player = collision.gameObject;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        canBuy = false;
        priceCanvas.gameObject.SetActive(false);
    }
    private void Start()
    {
        SellPrice = BuyPrice / 2;
    }
    private void Update()
    {
        if (canBuy)
        {
            /*
            if (Input.GetKeyDown(KeyCode.E) && Player.GetComponent<ChangeSkin>().SkinButtons[SkinCode].activeSelf)
            {
                Player.GetComponent<ChangeSkin>().SellSkin(SkinCode);
                Player.GetComponent<Model>().CoinAmount += SellPrice;
                Player.GetComponent<View>().UpdateCoins();
            }*/


            if (!Player.GetComponent<ChangeSkin>().SkinButtons[SkinCode].activeSelf)            //IF PLAYER DOESNT HAVE SKIN
            {
                if (Input.GetKeyDown(KeyCode.E) && Player.GetComponent<Model>().CoinAmount >= BuyPrice)
                {

                    Player.GetComponent<Model>().CoinAmount -= BuyPrice;
                    Player.GetComponent<ChangeSkin>().BuySkin(SkinCode);
                    Player.GetComponent<View>().UpdateCoins();
                }

                priceCanvas.gameObject.SetActive(true);
                priceText.text = BuyPrice.ToString();
                sellText.gameObject.SetActive(false);

            }
            else               //IF PLAYER HAS THE SKIN, SHOW SELL PRICE AND TEXT
            {


                priceCanvas.gameObject.SetActive(true);
                priceText.text = SellPrice.ToString();
                sellText.gameObject.SetActive(true);
                
                
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Player.GetComponent<ChangeSkin>().SellSkin(SkinCode);
                    Player.GetComponent<Model>().CoinAmount += SellPrice;
                    Player.GetComponent<View>().UpdateCoins();
                }
                
                
            }

            

        }
    }
    
}



