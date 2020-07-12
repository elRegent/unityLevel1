using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    private GameObject _player;
    // Start is called before the first frame update
    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");

        //player.transform.position += Vector3.up * 10;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
