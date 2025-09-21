using System.Collections;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steeringSpeed = 150f;
    [SerializeField] float movingSpeed = 14f;
    [SerializeField] float slowSpeed = 7f;
    [SerializeField] float boostSpeed = 24f;
    [SerializeField] float normalSpeed = 14f;

    void Start()
    {
        Debug.Log("Driver script started");
        movingSpeed = normalSpeed; 
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Entering Slow Zone.");
        StopAllCoroutines(); // stop any other timer
        StartCoroutine(SetTemporarySpeed(slowSpeed, 3f)); // 3 seconds slow
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "BoostZone") {
            Debug.Log("Entering Boost Zone");
            StopAllCoroutines(); // stop any other timer
            StartCoroutine(SetTemporarySpeed(boostSpeed, 3f)); // 3 seconds fast
        }
    }

    IEnumerator SetTemporarySpeed(float newSpeed, float duration)
    {
        movingSpeed = newSpeed; // change speed (to slow or fast)
        yield return new WaitForSeconds(duration); // wait few seconds
        movingSpeed = normalSpeed; // go back to normal speed
    }

    void Update()
    {
        float steeringAmount = Input.GetAxis("Horizontal") * steeringSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * movingSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steeringAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
