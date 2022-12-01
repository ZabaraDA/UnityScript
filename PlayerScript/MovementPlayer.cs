using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody rigidbodyLF;
    [SerializeField] private Rigidbody rigidbodyRL;
    [SerializeField] private Rigidbody rigidbodyCL;
    public float force = 5;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbodyRL.AddRelativeForce(Vector3.forward * force);
            rigidbodyLF.AddRelativeForce(Vector3.forward * force);
            transform.Translate(_speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbodyLF.AddRelativeForce(Vector3.forward * -force);
            rigidbodyRL.AddRelativeForce(Vector3.forward * -force);
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbodyRL.AddRelativeForce(Vector3.forward * -force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbodyRL.AddRelativeForce(Vector3.forward * force);
        }
    }
}
