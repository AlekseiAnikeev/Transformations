using UnityEngine;

public class Movement : MonoBehaviour
{
    private readonly float _speed = 3f;

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.forward);
    }
}
