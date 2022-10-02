using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noise : MonoBehaviour
{
    [SerializeField] private float amplitude = 1;
    [SerializeField] private float period = 1;
    private Vector3 initialPosition;

    private void Start() {
        initialPosition = transform.position;
    }
    private void Update() {
        //float x = amplitude * Mathf.Sin(2f * Mathf.PI * (Time.time / period));
        //transform.position = new Vector3(initialPosition.x + x, initialPosition.y + x, 0);
        float x = Mathf.Sin(Time.time * 5) + Mathf.Cos(Time.time / Mathf.PI) + Mathf.Cos(Time.time * 100);
        transform.position = new Vector3(initialPosition.x + x, initialPosition.y + x, 0);
    }
}
