using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Linq;

public class REDCapCommunicator : MonoBehaviour
{
    public void PostRequest(int record, string data, string field_name)
    {
        var client = new RestClient("https://redcap.nexs.ku.dk/api/");
        var request = new RestRequest();
        request.AddParameter("token", "94E1FEFEDE27F4FAC807932611C86EFE");
        request.AddParameter("content", "version");
        request.AddParameter("content", "record");
        request.AddParameter("format", "xml");
        request.AddParameter("type", "eav");
        request.AddParameter("overwriteBehavior", "overwite");
        request.AddParameter("forceAutoNumber", "false");
        request.AddParameter("data", "<records> <item> <record>" + record + "</record> <field_name>"+field_name+"</field_name> <value>" + data + "</value> <redcap_event_name>pre_intervention_arm_1</redcap_event_name> </item> </records>");
        request.AddParameter("returnContent", "count");
        request.AddParameter("returnFormat", "json");

        request.AddHeader("header", "value");
        var response = client.Post(request);
        var content = response.Content;
        print("HTTP Status: " + content);
    }

    public string GetRecordIdFromChildId(string id)
    {
        var rec_id = "";
        var client = new RestClient("https://redcap.nexs.ku.dk/api/");
        var request = new RestRequest();
        request.AddParameter("token", "94E1FEFEDE27F4FAC807932611C86EFE");
        request.AddParameter("content", "report");
        request.AddParameter("format", "json");
        request.AddParameter("report_id", "207");
        request.AddParameter("csvDelimiter", "");
        request.AddParameter("rawOrLabel", "raw");
        request.AddParameter("rawOrLabelHeaders", "raw");
        request.AddParameter("exportCheckboxLabel", "false");
        request.AddParameter("returnFormat", "json");

        var response = client.Post(request);
        var content = response.Content;
        JArray convertedJson = JArray.Parse(content);

        var Ids = convertedJson.SelectToken("$.[?(@.child_id=='" + id + "')]");
        if (Ids != null)
        {
            rec_id = Ids["record_id"].ToString();
            print("record_id : " + rec_id);
            return rec_id;
        }
        else
            return null;

    }
    public bool ValidateRecordId(string id)
    {
        var rec_id = "";
        var client = new RestClient("https://redcap.nexs.ku.dk/api/");
        var request = new RestRequest();
        request.AddParameter("token", "94E1FEFEDE27F4FAC807932611C86EFE");
        request.AddParameter("content", "report");
        request.AddParameter("format", "json");
        request.AddParameter("report_id", "207");
        request.AddParameter("csvDelimiter", "");
        request.AddParameter("rawOrLabel", "raw");
        request.AddParameter("rawOrLabelHeaders", "raw");
        request.AddParameter("exportCheckboxLabel", "false");
        request.AddParameter("returnFormat", "json");

        var response = client.Post(request);
        var content = response.Content;
        JArray convertedJson = JArray.Parse(content);

        var Ids = convertedJson.SelectTokens("$.[?(@.record_id=='" + id + "')]").ToList();
        if (Ids.Count != 0)
        {
            return true;
        }
        else
            return false;

    }

}
