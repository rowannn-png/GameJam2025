using UnityEngine;

public class LocationSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject[] objects; 
    private int curIndex = 0;
    private void Start()
    {
        UpdateObjects();
    }

    private void UpdateObjects()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i] != null)
            {
                // Get object sprites
                SpriteRenderer spriteRenderer = objects[i].GetComponent<SpriteRenderer>();
            }
        }
    }
    public void SwitchToNextLocation()
    {
        // Disable the current location
        if (curIndex >= 0 && curIndex < objects.Length)
        {
            if (objects[curIndex] != null)
            {
                objects[curIndex].SetActive(false);
            }
        }

        // Move to the next location
        curIndex = (curIndex + 1) % objects.Length;

        // Enable the new location
        if (curIndex >= 0 && curIndex < objects.Length)
        {
            if (objects[curIndex] != null)
            {
                objects[curIndex].SetActive(true);
            }
        }
        UpdateObjects();
    }
}