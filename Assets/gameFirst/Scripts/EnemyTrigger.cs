using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform _spawnPoint;

    private bool _enemyCreated = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (_enemyCreated)
        {
            return;
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(_enemy, _spawnPoint.position, _spawnPoint.rotation);
            _enemyCreated = true;
        }
    }
}
