using UnityEngine;

public class ReStart : MonoBehaviour
{
    private Vector3 PlayerStartPosition;
    private GameObject PlayerObject;
    void Start()
    {
        PlayerObject = GameObject.FindWithTag("Player");
        PlayerStartPosition = PlayerObject.transform.position;
    }

    public void PlayerRestartPosition()
    {
        PlayerObject.transform.position = PlayerStartPosition;
        var rigidBody2d = PlayerObject.GetComponent<Rigidbody2D>();
        rigidBody2d.velocity = Vector2.zero;
        rigidBody2d.angularVelocity = 0;
        PlayerObject.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}
