using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class CubeTracker : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;

    public TextMeshProUGUI infoText;

    void Update()
    {
        if (cube1 == null || cube2 == null || cube3 == null || infoText == null)
            return;

        Vector3 pos1 = cube1.transform.position;
        Vector3 pos2 = cube2.transform.position;

        if (Keyboard.current != null)
        {
            // A = Vector Addition
            if (Keyboard.current.aKey.wasPressedThisFrame)
            {
                Vector3 posadd = pos1 + pos2;

                cube3.transform.position = posadd;

                infoText.text = $"Sum: {posadd}";
                Debug.Log($"Sum: {posadd}");
            }

            // S = Vector Subtraction
            if (Keyboard.current.sKey.wasPressedThisFrame)
            {
                Vector3 possub = pos1 - pos2;

                cube3.transform.position = possub;

                infoText.text = $"Difference: {possub}";
                Debug.Log($"Difference: {possub}");
            }

            // D = Dot Product
            if (Keyboard.current.dKey.wasPressedThisFrame)
            {
                float dotResult = Vector3.Dot(pos1, pos2);

                // Convert scalar dot result into a position
                Vector3 dotVector = dotResult * Vector3.one;

                cube3.transform.position = dotVector;

                infoText.text = $"Dot: {dotResult}";
                Debug.Log($"Dot: {dotResult}");
            }

            // C = Cross Product
            if (Keyboard.current.cKey.wasPressedThisFrame)
            {
                Vector3 crossResult = Vector3.Cross(pos1, pos2);

                cube3.transform.position = crossResult;

                infoText.text = $"Cross: {crossResult}";
                Debug.Log($"Cross: {crossResult}");
            }
        }
    }
}