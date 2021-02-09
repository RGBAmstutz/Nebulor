using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] [Range(0f, 180f)] float spinSpeedMin = 180f;
    [SerializeField] [Range(180f, 360f)] float spinSpeedMax = 220f;

    // Update is called once per frame
    void Update()
    {
        SpinSpeed();
    }

    private void SpinSpeed()
    {
        float speedOfSpin = Random.Range(spinSpeedMin, spinSpeedMax);
        transform.Rotate(0, 0, speedOfSpin * Time.deltaTime);
    }
}
