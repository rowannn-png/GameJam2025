using UnityEngine;

public class LocationTrigger : MonoBehaviour
{
    [SerializeField] private LocationSwitcher locationSwitcher; // Reference to the LocationSwitcher script

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the location: " + gameObject.name);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Check if the object exiting the trigger is the player
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exited the location: " + gameObject.name);
            // Switch to the next location
            locationSwitcher.SwitchToNextLocation();
        }
    }
}
