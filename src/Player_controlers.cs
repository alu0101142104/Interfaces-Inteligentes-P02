using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controlers : MonoBehaviour {
  [Header("Player")]
  [Tooltip("Move speed of the character in m/s")]
  public float moveSpeed = 20.0f;
  [Tooltip("Growth rate")]
  public float GrowthRate = 1f;
  
  private Rigidbody rb;
  private int score = 0;
  private bool space_pressed = false;

  void Start() {
    rb = GetComponent<Rigidbody>();
  }

  void Update() {
    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");
    Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
    rb.position += movement;
    if (Input.GetKey(KeyCode.Z)) {
      rb.transform.Rotate(0, 1 * moveSpeed * 3 * Time.deltaTime, 0);
    }
    if (Input.GetKey(KeyCode.X)) {
      rb.transform.Rotate(0, -1 * moveSpeed * 3 * Time.deltaTime, 0);
    }
    if (Input.GetKey(KeyCode.Space)) {
      space_pressed = true;
    } else {
      space_pressed = false;
    }
  }

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Cylinder") {
      transform.localScale += new Vector3(GrowthRate, GrowthRate, GrowthRate);
      score++;
      // Imprime la puntación
      Debug.Log("Score: " + score);
    }
    if (collision.gameObject.tag == "Type A" && space_pressed) {
      Vector3 direction = new Vector3(collision.transform.position.x - rb.position.x, 0, collision.transform.position.z - rb.position.z);
      collision.transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
  }
}