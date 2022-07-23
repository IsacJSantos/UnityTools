using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

public static class SaveSerial
{
    static string _savePath = Application.persistentDataPath;

    public static bool SaveData<T>(T data, string fileName)
    {
        if (data == null || string.IsNullOrEmpty(fileName))
        {
            Debug.LogError($"Erro on try save data. Data is null or the fileName is empty. File Name: {fileName}");
            return false;
        }
        bool saved = false;

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream fs = File.Create($"{_savePath}/{fileName}.dat");

        try
        {
            formatter.Serialize(fs, data);
            saved = true;
            Debug.Log("<color=green>Data saved successfully</color>");
        }
        catch (System.Exception e)
        {
            throw new System.Exception($"Error on try save data. Error message: {e.Message}");
        }
        finally
        {
            fs.Close();
        }

        return saved;

    }

    public static T LoadData<T>(string fileName)
    {
        if (!File.Exists($"{_savePath}/{fileName}.dat"))
        {
            Debug.LogError("Error on try load data. This file does not exists");
            return default(T);
        }

        FileStream fs = File.Open($"{_savePath}/{fileName}.dat", FileMode.Open);
        T loadedData;

        try
        {
            BinaryFormatter formatter = new BinaryFormatter();
            loadedData = (T)formatter.Deserialize(fs);
            Debug.Log("<color=green>Data loaded successfully</color>");
        }
        catch (System.Exception e)
        {
            throw new System.Exception($"Error on try load data. Error message: {e.Message}");
        }
        finally
        {
            fs.Close();
        }

        return loadedData;
    }
}
