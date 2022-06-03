using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class ChangeSkin : MonoBehaviour
{
    Animator myAnimator;

    public RuntimeAnimatorController[] SkinControllers;
    
    public GameObject[] SkinButtons;

    [SerializeField]
    GameObject WardrobeContent;

    [SerializeField]
    GameObject changeSkinParticlePrefab;

    [SerializeField]
    Controller _Controller;

    [SerializeField]
    View _View;

    [SerializeField]
    Model _Model;

    // Start is called before the first frame update
    void Start()
    {
        
        _Model = this.GetComponent<Model>();
        _View = this.GetComponent<View>();
        _Controller = this.GetComponent<Controller>();
        myAnimator = this.GetComponent<Animator>();
        myAnimator.runtimeAnimatorController = SkinControllers[0];
        SkinButtons[0].GetComponent<Button>().interactable = false;

    }

    
    public void ChangeSkinTo(int skinNumber)
    {
        
        if(myAnimator.runtimeAnimatorController != SkinControllers[skinNumber])
        {
            for (int i = 0; i < SkinButtons.Length; i++)
            {
                SkinButtons[i].GetComponent<Button>().interactable = true;
            }
            SkinButtons[skinNumber].GetComponent<Button>().interactable = false;
            myAnimator.runtimeAnimatorController = SkinControllers[skinNumber];
            Instantiate(changeSkinParticlePrefab, this.transform);
        }
        

    }

    public void BuySkin(int skinNumber)
    {

        
        Debug.Log("Se compro la skin " + skinNumber);
        SkinButtons[skinNumber].SetActive(true);
        
    }
    public void SellSkin(int skinNumber)
    {
        SkinButtons[skinNumber].SetActive(false);
        
        if(SkinControllers[skinNumber] == this.gameObject.GetComponent<Animator>().runtimeAnimatorController)
        {
            ChangeSkinTo(0);
        }
        
    }
    
}
