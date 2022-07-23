using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class SaveExemple : MonoBehaviour
{
    [SerializeField] InputField _textinputField;
    [SerializeField] InputField _fileNameinputField;
    [SerializeField] Text _pointsText;


    int _points;
    public void AddPoints()
    {
        _points++;
        _pointsText.text = _points.ToString("N0");
    }

    public void SaveData()
    {
        InputData data = new InputData() { inputFieldValue = _textinputField.text, points = _points };

        string fileName = string.IsNullOrEmpty(_fileNameinputField.text) ? "TestInputData" : _fileNameinputField.text;
        SaveSerial.SaveData(data, fileName);
    }

    public void LoadData()
    {
        string fileName = string.IsNullOrEmpty(_fileNameinputField.text) ? "TestInputData" : _fileNameinputField.text;

        InputData data = SaveSerial.LoadData<InputData>(fileName);
        if (data == null) return;

        _textinputField.text = data.inputFieldValue;
        _points = data.points;
        _pointsText.text = _points.ToString("N0");
    }
}
[System.Serializable]
public class InputData
{
    public string inputFieldValue;
    public int points;
}
