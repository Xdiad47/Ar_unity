using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Runtime.Serialization;


public class GetMethod : MonoBehaviour
{
    InputField outputArea;

    [Serializable]
    public struct Items
    {
        public string x_axis;
        public string y_axis;
        //public Sprite Icon;
        public string z_axis;
    }

    Items[] allGames;
    [SerializeField] Sprite defaultIcon;


    void Start()
    {
        outputArea = GameObject.Find("OutputArea").GetComponent<InputField>();
        GameObject.Find("GetButton").GetComponent<Button>().onClick.AddListener(GetData);
    }

    void GetData() => StartCoroutine(GetData_Coroutine());

    IEnumerator GetData_Coroutine()
    {
        outputArea.text = "Loading...";
        //Change the link here
        string uri = "https://prod.wikibedtimestories.com/webservices/ARIES/api/test_get_All_Equity_Details.php?country=US";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError) {
                outputArea.text = request.error;

            }
            else {
                allGames = JsonHelper.GetArray<Items>(request.downloadHandler.text);
                outputArea.text = request.downloadHandler.text;

                Debug.Log(allGames);

            }

               
        }
    }
}