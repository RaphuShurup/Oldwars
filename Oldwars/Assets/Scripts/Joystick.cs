using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    [SerializeField]
    private RectTransform _center;
    [SerializeField]
    private RectTransform _knob;
    [SerializeField]
    private float _range;

    public bool _fixedJoystcik;
    public Vector2 direction;
    private bool _active;
    private Vector2 _pos;

    public bool moved = false;
    void Start()
    {
        ShowJoystick(false);
        _active = false;
    }

    void Update()
    {

            _pos = Input.mousePosition;
            if (Input.GetMouseButtonDown(0))
            {
                _active = true;
                _knob.position = _pos;
                _center.position = _pos;
                ShowJoystick(true);
            }
            else if (Input.GetMouseButton(0))
            {
                moved = true;
                _knob.position = _pos;
                _knob.position = _center.position + Vector3.ClampMagnitude(_knob.position - _center.position, _center.sizeDelta.x * _range);

                if (_knob.position != Input.mousePosition && !_fixedJoystcik)
                {
                    Vector3 outSideBoundsVector = Input.mousePosition - _knob.position;
                    _center.position += outSideBoundsVector;
                }

                direction = (_knob.position - _center.position).normalized;
            }

            else
                _active = false;

            if (!_active)
            {
                moved = false;
                ShowJoystick(false);
                direction = Vector2.zero;
            }
            //Debug.Log(direction);
        }

        //mainChar.transform.Translate(new Vector3(direction.x, 0f, direction.y) * speed * Time.deltaTime);

    public void ShowJoystick(bool state)
    {
        _center.gameObject.SetActive(state);
        _knob.gameObject.SetActive(state);
    }
}
