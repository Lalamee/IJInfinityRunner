using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{ 
    [SerializeField] private float _stepSize;
    [SerializeField] private float _speed;
    [SerializeField] private float _maxHeight;
    [SerializeField] private float _minHeight;
    private Vector3 _targetPosition;

    private void Start()
    {
        _targetPosition = transform.position;
    }

    private void Update()
    {
        if (_targetPosition != transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
        }
    }

    public void TryMoveUp()
    {
        if(_targetPosition.y < _maxHeight )
            SetNextPosition(_stepSize);
    }

    public void TryMoveDown()
    {
        if(_targetPosition.y > _minHeight)
            SetNextPosition(-_stepSize);
    }

    public void SetNextPosition(float stepSize)
    {
        _targetPosition = new Vector2(_targetPosition.x, _targetPosition.y + stepSize);
    }
}
