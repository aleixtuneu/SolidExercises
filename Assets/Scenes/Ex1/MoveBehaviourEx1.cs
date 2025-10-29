using UnityEngine;

public class MoveBehaviourEx1 : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D _rb;
    private void Awake()
    {
        _rb= GetComponent<Rigidbody2D>();
    }
    public void Move(Vector2 direction)
    {
        _rb.linearVelocity = new Vector2(direction.x * speed, _rb.linearVelocityY);
    }
}
