using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharechterTransition : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _objectSprite;
    [SerializeField] private Sprite _character1; 
    [SerializeField] private Sprite _character2;
    [SerializeField] private KeyCode _pressedKey;
    [SerializeField] private Transform _hatPosition; //Hat position
    [SerializeField] private float _timeForTransition;
    [SerializeField] private float _movingSpeed;
    private Transform _startingPosition;
    private bool _isFinished = false;
    private float _currentTime;



    void Start()
    {
        //_objectSprite.sprite = _character1;
        _startingPosition = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(_pressedKey))
        {
            StartTransition();
            Debug.Log("Key pressed");
        }

        else
            _currentTime = 0;
    }


    private void MoveToStartingPosition()
    {
        if (Vector2.Distance(transform.position, _startingPosition.position) > 0.1f)
            transform.Translate(transform.up * _movingSpeed * Time.deltaTime);
    }

    private void MoveToHatPosition()
    {
        if(Vector2.Distance(transform.position, _hatPosition.position) > 0.1f)
        transform.Translate(-transform.up * _movingSpeed * Time.deltaTime);
    }

    private void StartTransition()
    {
        _currentTime += Time.deltaTime;
    }
}
