using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private bool OnGraund = true;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.right * _speed);
    }

    private void Update()
    {
        if (Input.GetKeyDown("space") && OnGraund)
        {
            _rb.AddForce(transform.up * 800);
            OnGraund = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Graund")
        {
            OnGraund = true;
        }
    }
}
