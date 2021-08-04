using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed = 50f;
	public Rigidbody rb;
	private int score = 0;



	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Pickup")
		{
			score++;
			Debug.Log($"Score: {score}");
			Destroy(other.gameObject); // destroy
			// other.gameObject.SetActive(false); // deActivate

			
		}
	}

	void FixedUpdate()
	{
		float currentXPosition = Input.GetAxis("Horizontal");
		float currentZPosition = Input.GetAxis("Vertical");

		Vector3 dir = new Vector3(currentXPosition, 0, currentZPosition).normalized;

		Vector3 force = dir * speed * Time.deltaTime;

		rb.AddForce(force);

		
	}
}