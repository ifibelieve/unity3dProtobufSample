using UnityEngine;
using System.Collections;
using System.IO;

using ProtobufBundle.Protocols.PBClass.Common;

public class TestScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    TestEncDec();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
        {
            TestEncDec();
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            TestEncDec();
        }
	}

    private void TestEncDec()
    {
        InfoScene infoScene = new InfoScene();
        infoScene.sceneSid = "1";

        /*try
        {
            byte[] bytes1 = null;
            using (MemoryStream i1 = new MemoryStream())
            {
                ProtoBuf.Serializer.Serialize<InfoScene>(i1, infoScene);

                bytes1 = i1.ToArray();
            }

            InfoScene decInfo1 = null;
            using (MemoryStream o = new MemoryStream(bytes1))
            {
                decInfo1 = (InfoScene)ProtoBuf.Serializer.Deserialize<InfoScene>(o);
            }

            Debug.LogError(decInfo1.sceneSid);
        }
        catch (System.Exception e)
        {
            Debug.LogException(e);
        }
        */

        try
        {
            byte[] bytes2 = null;
            using (MemoryStream i2 = new MemoryStream())
            {
                //(new ProtoBufSerializer()).Serialize(i2, infoScene);
                ProtoBuf.Serializer.Serialize(i2, infoScene);
                bytes2 = i2.ToArray();
            }

            InfoScene decInfo2 = null;
            using (MemoryStream o2 = new MemoryStream(bytes2))
            {
                decInfo2 = (InfoScene)(new ProtoBufSerializer()).Deserialize(o2, null, typeof(InfoScene));
            }

            Debug.LogError(decInfo2.sceneSid);
        }
        catch (System.Exception e)
        {
            Debug.LogException(e);
        }
    }
}
