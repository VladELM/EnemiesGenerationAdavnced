using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _target;
    private bool _isAllowMove;

    private void Awake()
    {
        _isAllowMove = false;
    }

    private void Update()
    {
        if (_isAllowMove)
        {
            transform.LookAt(_target.position);
            transform.position = Vector3.MoveTowards(transform.position, _target.position,
                                                    _speed * Time.deltaTime);
        }
    }

    public void Initialize(Vector3 startPosition, Transform target)
    {
        transform.position = new Vector3(startPosition.x, transform.position.y, startPosition.z);
        _target = target;
        _isAllowMove = true;
    }
}
