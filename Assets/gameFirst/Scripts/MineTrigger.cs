using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var buildings = GameObject.FindGameObjectsWithTag("DestroyableByMineOne");
            var player = GameObject.FindGameObjectWithTag("Player");

            foreach (GameObject building in buildings)
            {
                Destroy(building);
            }

            Destroy(player);

            print("Game Over");
        }
    }
    
    /*private void OnTriggerExit(Collider collision)
    {

    }

    private void OnTriggerStay(Collider collision)
    {

    }*/
}
