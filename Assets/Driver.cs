using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks.Dataflow;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Allows to recreate the variable value at everypoint
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float bootSpeed = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveSpeedAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        // X, Y, Z
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveSpeedAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Bumps") {
            moveSpeed = slowSpeed;
            Debug.Log("Speed Bump!!!");    
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Boosts"){
            moveSpeed = bootSpeed;
            Debug.Log("Speed Boost!!!");
        }
        
    }

}
