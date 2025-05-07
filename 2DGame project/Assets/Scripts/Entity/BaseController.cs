using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;

    [SerializeField] private SpriteRenderer chracterRenderer;

    protected Vector2 movementDirection = Vector2.zero;
    public Vector2 MovementDirection  { get { return movementDirection; } } // 이동방향

    protected virtual void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    protected virtual void Update()
    {
        HandleAction();
    }
    protected virtual void FixedUpdate()
    {
        Movement(movementDirection);
    }
    protected virtual void HandleAction()
    {

    }
    private void Movement(Vector2 direction)
    {
        direction = direction * 7;
        _rigidbody.velocity = direction;
    }
}
