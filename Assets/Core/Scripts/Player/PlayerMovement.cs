using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rigidBody;

    private const string HORIZONTAL_AXIS = "Horizontal";

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxis(HORIZONTAL_AXIS);

        Vector2 newPosition = _rigidBody.position + new Vector2(moveX, 0) * _speed * Time.fixedDeltaTime;
        
        _rigidBody.MovePosition(newPosition);
    }
}
