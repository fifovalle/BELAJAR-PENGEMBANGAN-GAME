using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    Rigidbody2D _rb;

    float _speedPlayer = 5f; 
    float _controlHorizontal; 
    float _controlVertical;
    float _jumpForce = 100f;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        _controlHorizontal = Input.GetAxis("Horizontal"); 
        _controlVertical = Input.GetAxis("Vertical"); 

        Vector2 movement = new Vector2(_controlHorizontal, _controlVertical) * _speedPlayer;
        _rb.velocity = movement;

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            _rb.AddForce(new Vector2(0f, _jumpForce), ForceMode2D.Impulse);
        }
    }
}
