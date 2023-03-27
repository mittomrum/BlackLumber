using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public float speed = 12.0F;

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.SimpleMove(move*Time.deltaTime*speed);
    }
}