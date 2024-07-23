using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private float _speedRotation;

    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.RotateAround(transform.position, Vector3.up, _speedRotation * Time.deltaTime);
    }
}
