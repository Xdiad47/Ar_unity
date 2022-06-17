using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.Networking;
using System.IO;
using System.Text;
using System;

public class CreateObject : MonoBehaviour
{

    //InputField outputArea;

    // Start is called before the first frame update
    void Start()
    {
        GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        cylinder.transform.position = new Vector3(-2, 1, 0);

        // outputArea = GameObject.Find("InputField").GetComponent<InputField>();

        //GameObject.Find("GetButton").GetComponent<Button>().onClick.AddListener(GetData);


        // StartCoroutine(GetData());

    }

    // Update is called once per frame
    /* void Update()
     {

     }
     */

   /* void GetData() => StartCoroutine(GetData_Coroutine());


    IEnumerator GetData_Coroutine()
    {
        outputArea.text = "Loading...";
        string uri = "https://prod.wikibedtimestories.com/webservices/ARIES/api/test_get_All_Equity_Details.php?country=US";
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                outputArea.text = request.error;
            else
                outputArea.text = request.downloadHandler.text;
        }
    }*/

}
