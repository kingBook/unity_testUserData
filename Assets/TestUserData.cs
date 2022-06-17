using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUserData : MonoBehaviour {

    public UserData[] userDatas = new UserData[3];

    private void Start() {
        for (int i = 0, len = userDatas.Length; i < len; i++) {
            var userData = userDatas[i];
            if (userData.type == UserData.Type.String) {
                Debug.Log($"i:{i}, {userData.stringValue}");
            } else {
                Debug.Log($"i:{i}, {userData.gameObjectValue}");
            }
        }
    }


}
