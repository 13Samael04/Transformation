using UnityEngine;

public class CapsuleScale : MonoBehaviour
{
    [SerializeField] private Vector3 _scaleChange;

    void Update()
    {
        Grow();
    }

    private void Grow()
    {
        transform.localScale += _scaleChange * Time.deltaTime;
    }
}
