
using UnityEngine;

public class CameraRotateAround : MonoBehaviour {

    public float sensitivity = 3.5f;

    public float minAngleX = -40.0f;
    public float maxAngleX = 30.0f;

    private float _angleX = 0.0f;
    private float _angleY = 0.0f;

    private void Awake()
    {
        _angleX = transform.localEulerAngles.x;
        _angleY = transform.localEulerAngles.y;
    }

    private void Update()
    {
        if (!Input.GetMouseButton(0))
            return;

        _angleX -= Input.GetAxis("Mouse Y") * sensitivity;
        _angleY += Input.GetAxis("Mouse X") * sensitivity;

        _angleX = Mathf.Clamp(_angleX, minAngleX, maxAngleX);

        transform.localEulerAngles = new Vector3(_angleX, _angleY, transform.localEulerAngles.z);
    }
}