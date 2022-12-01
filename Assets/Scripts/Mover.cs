using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public GameObject cart;

    public float startX = 1.1f;
    public float minX = -2.5f;
    public float maxX = 3.5f;

    public float speed = 1;

    private float _currentX;
    private bool _toMax;

    private void Start()
    {
        Vector3 p = transform.position;
        p.x = startX;
        transform.position = p;
    }


    private void Update()
    {
        if (_toMax) _currentX += speed * Time.deltaTime;
        else _currentX -= speed * Time.deltaTime;


        if (_currentX <= minX)
        {
            _currentX = minX;
            _toMax = true;
        }
        else if (_currentX >= maxX)
        {
            _currentX = maxX;
            _toMax = false;
        }

        Vector3 pos = transform.position;
        pos.x = _currentX;
        transform.position = pos;
    }
}