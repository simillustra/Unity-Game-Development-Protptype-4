using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;

    private Rigidbody _enemyRigidbody;

    private GameObject _playerGameObjedt;
    // Start is called before the first frame update
    void Start()
    {
        _enemyRigidbody = GetComponent<Rigidbody>();
        _playerGameObjedt = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (_playerGameObjedt.transform.position - transform.position).normalized; 
        _enemyRigidbody.AddForce(lookDirection * speed);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
