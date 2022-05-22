using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Define.CameraMode _mode = Define.CameraMode.QuaterView;
    [SerializeField] private Vector3 _delta = new Vector3(0, 6, -5);
    [SerializeField] private GameObject _player = null;

    [Space] 
    [SerializeField] private Vector3 _diePosition = new Vector3(0, 3, -3.5f);
    [SerializeField] private float _dieLerpSmoothness = 0.5f;
    [SerializeField] private float _dieZoomTimer = 2f;
    
    public void SetPlayer(GameObject player)
    {
        _player = player;
    }

    public void SetCameraState(Define.CameraMode type)
    {
        _mode = type;
    }
    
    void Start()
    {
        
    }

    void LateUpdate()
    {
        if (_mode == Define.CameraMode.QuaterView)
        {
            if (!_player.IsVaild())
            {
                return;
            }
            
            RaycastHit hit;
            if (Physics.Raycast(_player.transform.position, _delta, out hit, _delta.magnitude, LayerMask.GetMask("Block")))
            {
                float dist = (hit.point - _player.transform.position).magnitude * 0.8f;
                transform.position = _player.transform.position + _delta.normalized * dist;
            }
            else
            {
                transform.position = _player.transform.position + _delta;
                transform.LookAt(_player.transform);   
            }
        }
        else if (_mode == Define.CameraMode.DieView)
        {
            _delta = Vector3.Lerp(_delta, _diePosition, _dieLerpSmoothness * Time.deltaTime * _dieZoomTimer);
            transform.position = _player.transform.position + _delta;
            transform.LookAt(_player.transform);   
        }
    }

    public void SetQuaterView(Vector3 delta)
    {
        _mode = Define.CameraMode.QuaterView;
        _delta = delta;
    }
}
