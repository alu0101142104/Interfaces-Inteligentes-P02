using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder_controlers : MonoBehaviour {
  [Header("Cylinder type B")]
  [Tooltip("Move speed of the character in m/s")]
  public float MoveSpeed = 10.0f;
  [Tooltip("Distance of activation")]
  public float perimeter = 30f;

  private Rigidbody rb;
  private GameObject player;

  void Start() {
    // perimeter = (2 * Mathf.PI * transform.localScale.x);
    rb = GetComponent<Rigidbody>();
    player = GameObject.FindWithTag("Player");
  }

  void Update() {
    float distance_player = Vector3.Distance(player.GetComponent<Rigidbody>().position, rb.position);
    if (distance_player < perimeter) {
      Vector3 direction = new Vector3(transform.position.x - player.transform.position.x, 0, transform.position.z - player.transform.position.z);
      transform.Translate(direction * Time.deltaTime);
    }
  }
}
