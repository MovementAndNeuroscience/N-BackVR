
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActiveFieldAtStartUp : MonoBehaviour
{
    // Start is called before the first frame update
    private TMP_InputField inputField;
    void Start()
    {
        inputField = GetComponent<TMP_InputField>();
        inputField.ActivateInputField();
    }

    // Update is called once per frame
    void Update()
    {
        inputField = GetComponent<TMP_InputField>();
        if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
        {
            inputField.text += "0";
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            inputField.text += "1"; 
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            inputField.text += "2";
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            inputField.text += "3";
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            inputField.text += "4";
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            inputField.text += "5";
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
        {
            inputField.text += "6";
        }
        if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
        {
            inputField.text += "7";
        }
        if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
        {
            inputField.text += "8";
        }
        if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
        {
            inputField.text += "9";
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            inputField.text += "a";
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            inputField.text += "b";
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            inputField.text += "c";
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            inputField.text += "d";
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            inputField.text += "e";
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            inputField.text += "f";
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            inputField.text += "g";
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            inputField.text += "h";
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            inputField.text += "i";
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            inputField.text += "j";
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            inputField.text += "k";
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            inputField.text += "l";
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            inputField.text += "m";
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            inputField.text += "n";
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            inputField.text += "o";
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            inputField.text += "p";
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            inputField.text += "q";
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            inputField.text += "r";
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            inputField.text += "s";
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            inputField.text += "t";
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            inputField.text += "u";
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            inputField.text += "v";
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            inputField.text += "w";
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            inputField.text += "x";
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            inputField.text += "y";
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            inputField.text += "z";
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            var length = inputField.text.Length;
            inputField.text = inputField.text.Remove(length - 1, 1); 
        }
    }
    public void activateField()
    {
        inputField.ActivateInputField();
    }
}
