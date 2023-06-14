using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharechterTransition : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] private KeyCode _pressedKey;

    void Update()
    {
        if (Input.GetKey(_pressedKey))
        {
            _animator.SetBool("KeyPressed", true);
        }
    }


    //private void MoveToStartingPosition()
    //{
    //    if (Vector2.Distance(transform.position, _startingPosition.position) > 0.1f)
    //        transform.Translate(transform.up * _movingSpeed * Time.deltaTime);
    //}

    //private void MoveToHatPosition()
    //{
    //    if(Vector2.Distance(transform.position, _hatPosition.position) > 0.1f)
    //    transform.Translate(-transform.up * _movingSpeed * Time.deltaTime);
    //}

    //private void StartTransition()
    //{
    //    _currentTime += Time.deltaTime;
    //}
}
