using UnityEngine;

public class Handel : MonoBehaviour
{
    public Transform target;
    public Camera mainCamera;
    private void Update()
    {
        Vector3 cursorPos = Input.mousePosition;
        
        Vector3 relPos = mainCamera.ScreenToWorldPoint(new Vector3(cursorPos.x, cursorPos.y, transform.position.z - mainCamera.transform.position.z));
        if (Input.anyKeyDown)
        {
            Debug.Log("World pos: " + relPos);
            target.position = relPos;
        }    
        
        float angle = (Mathf.Atan2(relPos.x, relPos.y) * Mathf.Rad2Deg)*-1f;
        
        Quaternion targetRotation = Quaternion.Euler(0f, 0f, angle);
        Debug.DrawLine(transform.position, relPos, Color.magenta, Time.deltaTime, false);
        
        transform.rotation = targetRotation;
    }
}