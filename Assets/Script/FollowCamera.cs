using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] GameObject followCar; // The car that the camera will follow

    // this thing position (camera) will change to the position of the car.

    void LateUpdate()
    {
       transform.position = followCar.transform.position + new Vector3(0, 0, -10);
    }
}
