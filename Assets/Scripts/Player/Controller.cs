using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    View _View;
    Model _Model;


    // Start is called before the first frame update
    void Start()
    {
        _View = this.GetComponent<View>();
        _Model = this.GetComponent<Model>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") > 0)        //GO RIGHT
        {
            _View.GoRight(true);
            _Model.GoRight(true);
        }
        else 
        {
            _View.GoRight(false);
            _Model.GoRight(false);
        }
        
        if (Input.GetAxis("Horizontal") < 0)
        {
            _View.GoLeft(true);
            _Model.GoLeft(true);
        }
        else 
        { 
            _View.GoLeft(false);
            _Model.GoLeft(false);
        }
       




        if(Input.GetAxis("Vertical")> 0)
        {
            _View.GoUp(true);
            _Model.GoUp(true);
        }
        else 
        {
            _View.GoUp(false);
            _Model.GoUp(false);

        }
        

        if (Input.GetAxis("Vertical") < 0)
        {
            _View.GoDown(true);
            _Model.GoDown(true);
        }
        else
        {
            _View.GoDown(false);
            _Model.GoDown(false);
        }

      

    
    }
}
