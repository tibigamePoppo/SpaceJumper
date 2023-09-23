using UnityEngine;

public class MeatDirection : MonoBehaviour
{
    Transform meatPosition;
    void Start()
    {
        SetMeatPosition();
    }

    public void SetMeatPosition()
    {
        meatPosition = FindObjectOfType<meat>().gameObject.transform;
    }

    void FixedUpdate()
    {
        Vector3 dir = meatPosition.transform.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.up, dir);
    }

}
