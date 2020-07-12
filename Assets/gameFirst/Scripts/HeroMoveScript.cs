using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMoveScript : MonoBehaviour
{
    [SerializeField] private float _speed = 3;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * _speed * Time.deltaTime;
        }*/

        float horizontal = Input.GetAxis("Horizontal");
        if(horizontal != 0)
        {
            transform.position += transform.right * horizontal * _speed * Time.deltaTime;
        }

        float vertical = Input.GetAxis("Vertical");
        if (vertical != 0)
        {
            transform.position += transform.forward * vertical * _speed * Time.deltaTime;
        }
    }
}
