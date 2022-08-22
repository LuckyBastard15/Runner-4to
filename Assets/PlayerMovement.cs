using UnityEngine;
using DG.Tweening;
using System.Collections;



public class PlayerMovement : MonoBehaviour
{
    private int _currentPosition = 0;
    private bool _isRight = true;

    [SerializeField] private Points[] _points = null;

    void Start()
    {
        UpdatePosition();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
       
    }

    public void MoveRight() 
    {
        if (_isRight)
        {
            _currentPosition++;
            _currentPosition = _currentPosition >= _points.Length ? 0 : _currentPosition;
            _isRight = false;
        }
        else
        {
            _isRight = true;
        }
        UpdatePosition();
    }
    public void MoveLeft()
    {
        if(_isRight)
        {
            _isRight = false;
        }
        else
        {
            _isRight = true;
            _currentPosition--;
            _currentPosition = _currentPosition < 0 ? _points.Length - 1 : _currentPosition;
        }
        UpdatePosition();
    }   
    private void UpdatePosition()
    {
        var currentPoint = _points[_currentPosition];
        var currentPositon = _isRight ? currentPoint.rightPos : currentPoint.leftPos; 
        transform.DOMove(currentPositon.position, 0.7f).SetEase(Ease.InOutSine);

    }

    
}
