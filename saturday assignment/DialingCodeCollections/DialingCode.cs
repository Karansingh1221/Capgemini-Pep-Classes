using System;
using System.Collections;
using System.Collections.Generic;
namespace DialingCodesApp{
    public static class DialingCodes{
        public static Dictionary<int,string> codes=new Dictionary<int,string>();
    
    public static Dictionary<int,string> GetEmptyDictionary(){
        Dictionary<int,string> code=new Dictionary<int,string>();
        // codes=code;
        return code;
    } 
    public static Dictionary<int,string> GetExistingDictionary(){
        Dictionary<int,string> code=new Dictionary<int,string>();
        code.Add(1,"United States Of America");
        code.Add(55,"brazil");
        code.Add(91,"India");
        // codes=code;
        return code;
    }
    public static Dictionary<int,string> AddCountryToEmptyDictionary(int ccode,string cname){
        Dictionary<int,string> dict=new Dictionary<int,string>();
        dict.Add(ccode,cname);
        return dict;
    }
    public static Dictionary<int,string> AddCountryToExistingDictionary(Dictionary<int,string> dict,int code,string name){
        dict[code]=name;
        return dict;
    }
    public static string GetCountryName(Dictionary<int,string> dict,int code){
        if(dict.ContainsKey(code)){
            return dict[code];
        }
        return "";
    }
    public static bool CheckCodeExists(Dictionary<int,string> dict,int code){
        if(dict.ContainsKey(code)){
            return true;
        }
        return false;
    }
    public static Dictionary<int,string> UpdateDictionary(Dictionary<int,string> dict,int code,string name){
        if(dict.ContainsKey(code)){
            dict[code]=name;
        }
        return dict;
    }
    public static Dictionary<int,string> RemoveCountry(Dictionary<int,string> dict,int code){
        if(dict.ContainsKey(code)){
            dict.Remove(code);
        }
        return dict;
    }
    public static string LongestCountryName(Dictionary<int,string> dict){
        string str="";
        foreach(var v in dict){
            if(v.Value.Length>str.Length){
                str=v.Value;
            }
        }
        return str;
    }
    }

}