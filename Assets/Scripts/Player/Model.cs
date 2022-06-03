using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    float speed;

    View _View;
    Controller _Controller;

    public delegate void myDelegate();
    public myDelegate movementDelegate;


    public Rigidbody2D _rb;

    public bool canMove = true;

    public int CoinAmount;


    void Start()
    {
        _View = this.GetComponent<View>();
        _Controller = this.GetComponent<Controller>();

        _rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoUp(bool state)
    {
        if (canMove)
        {
            if (state == true)
            {

                _rb.AddForce(Vector2.up * speed);
            }
            else _rb.velocity = new Vector2(_rb.velocity.x, 0);
        }
        
    }
    public void GoDown(bool state)
    {
        if (canMove)
        {

            if (state == true)
            {

                _rb.AddForce(-Vector2.up * speed);
            }
            else _rb.velocity = new Vector2(_rb.velocity.x, 0);
        }
    }
    public void GoRight(bool state)
    {
        if (canMove)
        {

            if (state == true)
            {

                _rb.AddForce(Vector2.right * speed);
            }
            else _rb.velocity = new Vector2(0, _rb.velocity.y);
        }
    }
    public void GoLeft(bool state)
    {
        if (canMove)
        {

            if (state == true)
            {
                _rb.AddForce(-Vector2.right * speed);
            }
            else _rb.velocity = new Vector2(0, _rb.velocity.y);
        }
    }

    public void EnableMovement()
    {
        canMove = true;
    }

    
}
