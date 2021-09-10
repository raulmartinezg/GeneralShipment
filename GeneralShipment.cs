using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Net;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void GeneralShipment ()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://192.168.25.9/LinkOtm/api/OracleLink/GetShipment");
        request.Method = "GET";
        request.ContentLength = 0;
        request.Credentials = CredentialCache.DefaultCredentials;
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        response.Close();
    }
}
