using UnityEngine;
using UnityEngine.InputSystem;

public class Throw : MonoBehaviour
{
    [SerializeField] private float _throwMultiplier;
    private Vector3 _screenPoint;
    private Vector3 _offset;
    private Rigidbody _rigidbody;
    private Vector3 _startDragPosition;
    private Vector3 _endDragPosition;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        _screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        _offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _screenPoint.z));
    }

    void OnMouseDrag()
    {
        _startDragPosition = Input.mousePosition;
        Vector3 curScreenPoint = new(Input.mousePosition.x, Input.mousePosition.y, _screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + _offset;
        transform.position = curPosition;
    }

    private void OnMouseUp()
    {
        _endDragPosition = Input.mousePosition;
        Vector3 dragVector = _endDragPosition - _startDragPosition;
        float dragDistance = dragVector.magnitude;

        dragDistance = Mathf.Clamp(dragDistance, 0f, 500f); ;
        _rigidbody.AddForce(_throwMultiplier * dragDistance * Vector3.forward, ForceMode.Impulse);
    }
}