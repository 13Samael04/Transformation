
using UnityEngine;

public class SphereMovable : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += _movementDirection * Time.deltaTime;
    }
}
