﻿using Assets.Scripts.C_Framework;
using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    //在这里找出你当前工程所有的场景文件，假设你只想把部分的scene文件打包 那么这里可以写你的条件判断 总之返回一个字符串数组。
    static string[] GetBuildScenes()
    {
        List<string> names = new List<string>();
        foreach (EditorBuildSettingsScene e in EditorBuildSettings.scenes)
        {
            if (e == null)
                continue;
            if (e.enabled)
                names.Add(e.path);
        }
        return names.ToArray();
    }

    static void BuildForAndroid()
    {

        DeleteFolder(projectRootPath + "/" + projectName);

        if (channel == "null")
            //string path = Application.dataPath +"/" + Function.projectName+".apk";
            //BuildPipeline.BuildPlayer(GetBuildScenes(), path, BuildTarget.Android, BuildOptions.None);
            Debug.Log(channel);




    //得到渠道的名称
    static string ChannelName

    static void DeleteFolder(string dir)
                }

    static void CopyDirectory(string sourcePath, string destinationPath)

}