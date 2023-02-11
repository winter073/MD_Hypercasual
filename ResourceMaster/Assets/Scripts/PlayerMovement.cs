using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private float _moveSpeed;

    public int wood;
    public bool treeDestroy;
    private GameObject tree;
    private bool triggeringTree;
    public int currentTool;

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);

        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        }
    }

    
    /*public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wood"))
        {
            Debug.Log("Wood collected.");
            Destroy(other.gameObject);
        }

        if(other.tag == "Tree"){
            triggeringTree = true;
            tree = other.gameObject;
        }

         if (other.gameObject.CompareTag("Tree"))
        {
            Debug.Log("Tree destroyed.");
            Destroy(other.gameObject);
            treeDestroy = true;
            
        }
    }*/ 

    /* public void OnTriggerExit(Collider other){
        triggeringTree = false;
        tree = null;
    }*/  
}
