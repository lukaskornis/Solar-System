using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed;

    void Update()
    {
        GetComponent<Transform>().Rotate(0,speed,0);
    }
}