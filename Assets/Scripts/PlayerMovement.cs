using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    private Quaternion _normalRotation;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _normalRotation = transform.rotation;
    }

    private void Update()
    {
        transform.rotation = _normalRotation;

        if (Input.GetKey(KeyCode.D))
            transform.Translate(_speed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.D))
            _animator.SetBool(AnimatorPlayer.Params.IsRunRight, true);

        if (Input.GetKeyUp(KeyCode.D))
            _animator.SetBool(AnimatorPlayer.Params.IsRunRight, false);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(-_speed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.A))
            _animator.SetBool(AnimatorPlayer.Params.IsRunLeft, true);

        if (Input.GetKeyUp(KeyCode.A))
            _animator.SetBool(AnimatorPlayer.Params.IsRunLeft, false);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.AddForce(Vector2.up * _jumpForce);
            _animator.SetTrigger(AnimatorPlayer.Params.Jump);
        }
    }
}

public static class AnimatorPlayer
{
    public static class Params
    {
        public const string IsRunRight = nameof(IsRunRight);
        public const string IsRunLeft = nameof(IsRunLeft);
        public const string Jump = nameof(Jump);
    }
}
