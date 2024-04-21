using UnityEngine;

public class MovementExpansion : MonoBehaviour
{
    private readonly float _rotateSpeed = 30f;
    private readonly float _moveSpeed = 3f;
    private readonly float _expansionSpeed = 0.1f;

    private void Update()
    {
        Movement();
        Rotate();
        Expansion();
    }

    private void Rotate()
    {
        transform.Rotate(_rotateSpeed * Time.deltaTime * Vector3.up);
    }

    private void Movement()
    {
        transform.Translate(_moveSpeed * Time.deltaTime * Vector3.forward);
    }

    private void Expansion()
    {
        transform.localScale += _expansionSpeed * Time.deltaTime * Vector3.one;
    }
}
