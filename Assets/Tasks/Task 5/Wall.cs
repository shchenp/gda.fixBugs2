﻿using UnityEngine;

/// <summary>
/// Измените этот скрипт
/// </summary>
public class Wall : MonoBehaviour
{
    [SerializeField]
    private Detector _detector;
    [SerializeField] 
    private Vector3 _targetPosition = new(0, 0, 0f);

    private void Awake()
    {
        
    }

    private void ChangePosition()
    {
        transform.position = _targetPosition;
    }
}