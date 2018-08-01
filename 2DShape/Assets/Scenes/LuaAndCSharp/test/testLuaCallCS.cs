using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testLuaCallCS : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LuaCallCSharp callCS=new LuaCallCSharp();
         
	    Program pro = new Program();
        string script = "";
        object[] arguments=null;
	   
	    arguments = new object[] {  4, 265 };
	    object result = callCS.CallStaticFunc(script, pro, "Add", arguments);
	    print(result);
        /////////////////////
	    arguments = new object[] { 2344, 265 };
       
	    result = callCS.CallFunction("", pro, "Sub", arguments);
        print(result);
	}

    // Update is called once per frame
    void Update () {
		
	}
}
