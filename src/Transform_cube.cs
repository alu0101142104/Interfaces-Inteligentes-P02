using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_cube : MonoBehaviour {
  private GameObject player;
  private GameObject capsule;
  private Rigidbody rb;

  // Start is called before the first frame update
  void Start() {
    player = GameObject.FindWithTag("Player");
    capsule = GameObject.FindWithTag("Capsule");
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update() {
    float distance_player = Vector3.Distance(player.GetComponent<Rigidbody>().position, rb.position);
    if (distance_player < 30f) {
      rb.transform.localScale = new Vector3(15, 10, 15);
    }
    float distance_capsule = Vector3.Distance(capsule.GetComponent<Rigidbody>().position, rb.position);
    if (distance_capsule < 30f) {
      rb.transform.localScale = new Vector3(5, 3, 5);
    }
  }
}
