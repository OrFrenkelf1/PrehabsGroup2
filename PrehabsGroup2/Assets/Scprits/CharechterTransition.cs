using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharechterTransition : MonoBehaviour
{
    [SerializeField] Animator _animator;
    [SerializeField] private GameObject hatWithEar;
    [SerializeField] private GameObject hat;
    [SerializeField] private GameObject bunny;
    [SerializeField] private GameObject amongUs;
    [SerializeField] private Transform transHat;
    [SerializeField] private Transform transBunny;
    [SerializeField] private Transform transAmongUs;
    


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetBool("Pressed1", true);
            Destroy(hatWithEar);
            Instantiate(hat, transHat);
            Instantiate(bunny, transBunny);
            Debug.Log("Animation started!");

            Destroy(bunny);
            Instantiate(amongUs, transAmongUs);
            Debug.Log("Reached the midpoint of the animation!");
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
