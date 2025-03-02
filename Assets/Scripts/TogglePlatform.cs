using UnityEngine;

public class TogglePlatform : MonoBehaviour
{
    [SerializeField] private GameObject[] platformObjects; 
    private int state = 0;

    private void Start()
    {
        // Disable all platform objects initially except the first one
        for (int i = 0; i < platformObjects.Length; i++)
        {
            if (platformObjects[i] != null)
            {
                platformObjects[i].SetActive(i == state); // Enable only the first platform
            }
        }
    }

    private void Update()
    {
        // If no toggle key is set or no platforms exist, do nothing
        if (KeyCode.Space == KeyCode.None || platformObjects.Length == 0) return;

        // Check if the toggle key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Disable the current platform
            if (platformObjects[state] != null)
            {
                platformObjects[state].SetActive(false);
            }

            // Move to the next platform
            state = (state + 1) % platformObjects.Length; // Cycle through platforms

            // Enable the new platform
            if (platformObjects[state] != null)
            {
                platformObjects[state].SetActive(true);
            }
        }
    }
}