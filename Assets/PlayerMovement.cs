using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float xAxisMovement;
    private void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(translation / xAxisMovement, translation, 0);
    }
}
