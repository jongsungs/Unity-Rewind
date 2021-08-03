using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    Rigidbody m_rigidBody;
    // Start is called before the first frame update
    private void Awake()
    {
        m_rigidBody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        m_rigidBody.AddForce(Vector3.up * 300f);
        m_rigidBody.AddForce(Vector3.left * 300f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
