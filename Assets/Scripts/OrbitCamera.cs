using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    public Transform target;

    // camera orbit settings
    public float cameraDistance = 10f;
    public float xSpeed = 720.0f;
    public float ySpeed = 720.0f;

    // camera scroll settings
    public float scrollSpeed = 4f;
    public float minDistance = 5f;
    public float maxDistance = 12f;

    public int orbitMouseButton = 2; // 0=left, 1=right, 2=middle

    float yaw; // orbit around the y-axis
    float pitch; // orbit around the x-axis

    void Start()
    {
           if (!target)
        {
            Debug.LogError("OrbitCamera: No target set.");
            enabled = false;
            return;
        }

        yaw = transform.eulerAngles.y;
        pitch = transform.eulerAngles.x;
    }

    void LateUpdate()
    {
        if (Input.GetMouseButton(orbitMouseButton))
        {
            yaw += Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime;
            pitch -= Input.GetAxis("Mouse Y") * ySpeed * Time.deltaTime;
            //pitch = Mathf.Clamp(pitch, -80f, 80f);
        }

        transform.rotation = Quaternion.Euler(pitch, yaw, 0f);
        transform.position = target.position - (transform.rotation * Vector3.forward * cameraDistance);

        cameraDistance -= Input.mouseScrollDelta.y / scrollSpeed;
        cameraDistance = Mathf.Clamp(cameraDistance, minDistance, maxDistance);
    }
}
