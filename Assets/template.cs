using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using KModkit;
using Rnd = UnityEngine.Random;

//HI :3 gl with modding


     // this template here need to be the EXACT same thing as yo module type
public class template : MonoBehaviour {
     // might aswell name the script file the same thing

    // Modding Tutorial by Deaf: https://www.youtube.com/watch?v=YobuGSBl3i0

    public KMBombInfo Bomb;
    public KMAudio Audio;
    public KMBombModule Module  ;

    string ModuleName;
    static int ModuleIdCounter = 1;
    int ModuleId;
    private bool ModuleSolved;

    void Awake () { //Shit that happens before Start
        ModuleName = Module.ModuleDisplayName;
        ModuleId = ModuleIdCounter++;
        GetComponent<KMBombModule>().OnActivate += Activate;
        /*
         * How to make buttons work:
         * 
        foreach (KMSelectable object in keypad) {
            object.OnInteract += delegate () { keypadPress(object); return false; };
        }
        */

        //button.OnInteract += delegate () { buttonPress(); return false; };

        //keypadPress() and buttonPress() you have to make yourself and should just be what happens when you press a button. (deaf goes through it probably)
    }

    void Activate () { //Shit that should happen when the bomb arrives (factory)/Lights turn on

    }

    void Start () { //Shit
        
    }

    void Update () { //Shit that happens at any point after initialization

    }

    void Solve () { //Call this method when you want the module to solve
        Module.HandlePass();
        Log("Correct! Module Solved.");
        ModuleSolved = true;
    }

    void Strike () { //Call this method when you want ot module to strike
        Module.HandleStrike();
        Log("Incorrect! Strike Issued.");
    }

    void Log (string message) { //I did the logging for you <3. just do Log("message"); for logging (and please log like OMG just log its so easy esp with this)
        //If this underlined red for you (giving a compiler error), hover it and click on like the show possible fixes text, then click on upgrade this/all projects to c# version 6.
        Debug.Log($"[{ModuleName} #{ModuleId}] {message}");
    }

#pragma warning disable 414
    private readonly string TwitchHelpMessage = @"Use !{0} to do something.";
#pragma warning restore 414

    // Twitch Plays (TP) documentation: https://github.com/samfundev/KtaneTwitchPlays/wiki/External-Mod-Module-Support

    IEnumerator ProcessTwitchCommand (string Command) {
        yield return null;
    }

    IEnumerator TwitchHandleForcedSolve () {
        yield return null;
    }
}
