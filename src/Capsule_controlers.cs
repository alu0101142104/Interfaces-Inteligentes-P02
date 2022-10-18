using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule_controlers : MonoBehaviour {
  // Start is called before the first frame update
  [Header("Player")]
  [Tooltip("Move speed of the character in m/s")]
  public float moveSpeed = 20.0f;
  private Rigidbody rb;
  void Start() {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update() {
    // Mover con i,j, l, m
    if (Input.GetKey(KeyCode.I)) {
      rb.position += new Vector3(0, 0, 1) * moveSpeed * Time.deltaTime;
    }
    if (Input.GetKey(KeyCode.J)) {
      rb.position += new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime;
    }
    if (Input.GetKey(KeyCode.L)) {
      rb.position += new Vector3(1, 0, 0) * moveSpeed * Time.deltaTime;
    }
    if (Input.GetKey(KeyCode.K)) {
      rb.position += new Vector3(0, 0, -1) * moveSpeed * Time.deltaTime;
    }
  }
}
