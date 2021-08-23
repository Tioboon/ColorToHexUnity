using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class ColorHelper
{
    public static Color GetColorByHex(string hex)
    {
        var redHex = hex[0].ToString() + hex[1];
        var greenHex = hex[2].ToString() + hex[3];
        var blueHex = hex[4].ToString() + hex[5];
        var r = GetRGBPerHex(redHex) / 255f;
        var g = GetRGBPerHex(greenHex) / 255f;
        var b = GetRGBPerHex(blueHex) / 255f;
        Debug.Log(r + " " + g + " " + b);
        var newColor = new Color(r, g, b);
        return newColor;
    }

    private static int GetRGBPerHex(string code)
    {
        var result = 0;
        switch (code[0])
        {
            case '1':
                result += 16;
                break;
            case '2':
                result += 32;
                break;
            case '3':
                result += 48;
                break;
            case '4':
                result += 64;
                break;
            case '5':
                result += 80;
                break;
            case '6':
                result += 96;
                break;
            case '7':
                result += 112;
                break;
            case '8':
                result += 128;
                break;
            case '9':
                result += 144;
                break;
            case 'A':
                result += 160;
                break;
            case 'B':
                result += 176;
                break;
            case 'C':
                result += 192;
                break;
            case 'D':
                result += 208;
                break;
            case 'E':
                result += 224;
                break;
            case 'F':
                result += 240;
                break;
        }
        switch (code[0])
        {
            case '1':
                result += 1;
                break;
            case '2':
                result += 2;
                break;
            case '3':
                result += 3;
                break;
            case '4':
                result += 4;
                break;
            case '5':
                result += 5;
                break;
            case '6':
                result += 6;
                break;
            case '7':
                result += 7;
                break;
            case '8':
                result += 8;
                break;
            case '9':
                result += 9;
                break;
            case 'A':
                result += 10;
                break;
            case 'B':
                result += 11;
                break;
            case 'C':
                result += 12;
                break;
            case 'D':
                result += 13;
                break;
            case 'E':
                result += 14;
                break;
            case 'F':
                result += 15;
                break;
        }

        Debug.Log(result);
        return result;
    }

    public static string GetHexCode(Color color)
    {
        var redHex = GetHexPerColor(Mathf.RoundToInt(color.r * 255));
        var greenHex = GetHexPerColor(Mathf.RoundToInt(color.g * 255));
        var blueHex = GetHexPerColor(Mathf.RoundToInt(color.b * 255));
        var result = redHex + greenHex + blueHex;
        return result;
    }
    private static string GetHexPerColor(float amount)
    {
        var firstDefiner = amount * 0.0627450980392157;
        var secondDefiner = amount % 16;
        var intFirstDefiner = Mathf.FloorToInt((float)firstDefiner);
        var intSecondDefiner = Mathf.FloorToInt(secondDefiner);
        var result = "";
        switch (intFirstDefiner) 
        {
         case 0:
             result += 0;
             break;
         case 1:
             result += 1;
             break;
         case 2:
             result += 2;
             break;
         case 3:
             result += 3;
             break;
         case 4:
             result += 4;
             break;
         case 5:
             result += 5;
             break;
         case 6:
             result += 6;
             break;
         case 7:
             result += 7;
             break;
         case 8:
             result += 8;
             break;
         case 9:
             result += 9;
             break;
         case 10:
             result += 'A';
             break;
         case 11:
             result += 'B';
             break;
         case 12:
             result += 'C';
             break;
         case 13:
             result += 'D';
             break;
         case 14:
             result += 'E';
             break;
         case 15:
             result += 'F';
             break;
         default:
             Debug.Log("Invalid Value");
             break;
        }
     
     switch (intSecondDefiner)
     {
         case 0:
             result += 0;
             break;
         case 1:
             result += 1;
             break;
         case 2:
             result += 2;
             break;
         case 3:
             result += 3;
             break;
         case 4:
             result += 4;
             break;
         case 5:
             result += 5;
             break;
         case 6:
             result += 6;
             break;
         case 7:
             result += 7;
             break;
         case 8:
             result += 8;
             break;
         case 9:
             result += 9;
             break;
         case 10:
             result += 'A';
             break;
         case 11:
             result += 'B';
             break;
         case 12:
             result += 'C';
             break;
         case 13:
             result += 'D';
             break;
         case 14:
             result += 'E';
             break;
         case 15:
             result += 'F';
             break;
         default:
             Debug.Log("Invalid Value");
             break;
     }
     return result;
 }
}
