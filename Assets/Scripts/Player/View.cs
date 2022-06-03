using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class View : MonoBehaviour
{

    Controller _Controller;
    Model _Model;

    public Animator myAnimator;

    [SerializeField]
    GameObject Wardrobe;


    [SerializeField]
    TMP_Text moneyText;

    // Start is called before the first frame update
    void Start()
    {
        _Controller = this.GetComponent<Controller>();
        _Model = this.GetComponent<Model>();
        myAnimator = this.GetComponent<Animator>();

        UpdateCoins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoUp(bool state)
    {
        if(state == true)
        {
            myAnimator.SetBool("UpMovement", true);
            myAnimator.SetBool("DownMovement", false);
        }
        else
        {
            myAnimator.SetBool("UpMovement", false);
        }
    }

    public void GoDown(bool state)
    {
        if (state == true)
        {
            myAnimator.SetBool("DownMovement", true);
            myAnimator.SetBool("UpMovement", false);
        }
        else
        {
            myAnimator.SetBool("DownMovement", false);
        }
    }
    public void GoRight(bool state)
    {
        if(state == true)
        {
            myAnimator.SetBool("RightMovement", true);
            myAnimator.SetBool("LeftMovement", false);
        }
        else
        {
            myAnimator.SetBool("RightMovement", false);
        }
    }
    public void GoLeft(bool state)
    {
        if(state == true)
        {
            myAnimator.SetBool("LeftMovement", true);
            myAnimator.SetBool("RightMovement", false);
        }
        else
        {
            myAnimator.SetBool("LeftMovement", false);
        }
    }

    public void ShowWardrobe()
    {
        Wardrobe.SetActive(!Wardrobe.activeSelf);
    }

    public void UpdateCoins()
    {
        moneyText.text = _Model.CoinAmount.ToString();
    }
}
