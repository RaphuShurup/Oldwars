using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;
    private Transform _player;
    private Animator animator;
    [SerializeField] private float speed;
    private void Start()
    {
        _player = transform;
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (_joystick.moved)
        {
            animator.SetBool("Run", true);
            transform.position += (Vector3.right * _joystick.direction.x + Vector3.forward * _joystick.direction.y)  * (Time.deltaTime * speed);
            _player.forward = new Vector3(_joystick.direction.x, 0, _joystick.direction.y)  * (Time.deltaTime * speed);
        }
        else
        {
            animator.SetBool("Run", false);
        }
        
    }
}
