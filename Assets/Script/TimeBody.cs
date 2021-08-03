using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimeBody : MonoBehaviour
{

    public bool m_isRewinding = false;

    List<Vector3> m_position;
    Rigidbody rb;


    void Start()
    {
        m_position = new List<Vector3>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            StartRewind();
        if (Input.GetKeyUp(KeyCode.Return))
            StopRewind();
    }
    void FixedUpdate()
    {
        if (m_isRewinding)
            Rewind();
        else
            Record();
    }
    void Record()
    {
        m_position.Insert(0, transform.position);
    }
    void Rewind()
    {
        if (m_position.Count > 0)
        {
            transform.position = m_position[0];
            m_position.RemoveAt(0);
        }
        else
        {
            StopRewind();
        }
    }
    public void StartRewind()
    {
        m_isRewinding = true;
       rb.isKinematic = true;
    }
    public void StopRewind()
    {
        m_isRewinding = false;
        rb.isKinematic = false;
    }
}

