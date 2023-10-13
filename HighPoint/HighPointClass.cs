using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MelonLoader;
using HarmonyLib;
using System.Reflection;
using UnityEngine.SceneManagement;

namespace HighPoint
{
    public class HighPointClass : MelonMod
    {
        public override void OnUpdate()
        {
            Scene scene = SceneManager.GetActiveScene();
            var localMilk = GameObject.Find("Milk");
            if (scene.name == "0Tutorial")
            {
                localMilk.transform.localPosition = new Vector3(0, 18, 0);
            }
            else if (scene.name == "1Sandbox0")
            {
                localMilk.transform.localPosition = new Vector3(5, 43, 12);
            }
            else if (scene.name == "2Sandbox1")
            {
                localMilk.transform.localPosition = new Vector3(246, 161, -25);
            }
            else if (scene.name == "3Sandbox2")
            {
                localMilk.transform.localPosition = new Vector3(93, 204, -58);
            }
            else if (scene.name == "4Escape0")
            {
                localMilk.transform.localPosition = new Vector3(0, 36, 145);
            }
            else if (scene.name == "5Escape1")
            {
                localMilk.transform.localPosition = new Vector3(20, 31, 59);
            }
            else if (scene.name == "6Escape2")
            {
                localMilk.transform.localPosition = new Vector3(69, 41, -458);
            }
            else if (scene.name == "7Escape3")
            {
                localMilk.transform.localPosition = new Vector3(-89, 22, -5);
            }
            else if (scene.name == "8Sky0")
            {
                localMilk.transform.localPosition = new Vector3(39.9512f, 30.5f, -12.2069f);
            }
            else if (scene.name == "9Sky1")
            {
                localMilk.transform.localPosition = new Vector3(63, 42, 124);
            }
            else if (scene.name == "10Sky2")
            {
                localMilk.transform.localPosition = new Vector3(128, 43, -4);
            }
        }
    }
}
