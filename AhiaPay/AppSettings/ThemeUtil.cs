﻿using System;
using System.Collections.Generic;

namespace AhiaPay.AppSettings;
public static class ThemeUtil
{
    public static void ApplyDarkTheme(this ResourceDictionary resources)
    {
        if (resources != null)
        {
            var mergedDictionaries = resources.MergedDictionaries;
            var lightTheme = mergedDictionaries.OfType<LightTheme>().FirstOrDefault();
            if (lightTheme != null)
            {
                mergedDictionaries.Remove(lightTheme);
            }

            mergedDictionaries.Add(new DarkTheme());
            AppSettings.Instance.IsDarkTheme = true;
        }
    }

    public static void ApplyLightTheme(this ResourceDictionary resources)
    {
        if (resources != null)
        {
            var mergedDictionaries = resources.MergedDictionaries;

            var darkTheme = mergedDictionaries.OfType<DarkTheme>().FirstOrDefault();
            if (darkTheme != null)
            {
                mergedDictionaries.Remove(darkTheme);
            }

            mergedDictionaries.Add(new LightTheme());
            AppSettings.Instance.IsDarkTheme = false;
        }
    }

    public static void ApplyColorSet(int index)
    {
        switch (index)
        {
            case 0:
                ApplyColorSet1();
                break;
            case 1:
                ApplyColorSet2();
                break;
            case 2:
                ApplyColorSet3();
                break;
            case 3:
                ApplyColorSet4();
                break;
            case 4:
                ApplyColorSet5();
                break;
        }
    }

    public static void ApplyColorSet1()
    {
        //if (AppSettings.Instance.IsDarkTheme)
        //{
        //    Application.Current.Resources["PrimaryColor"] = Color.FromArgb("#42A1FF");
        //    Application.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#0F88FF");
        //    Application.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#006EDB");
        //    Application.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#75BAFF");
        //    Application.Current.Resources["PrimaryLight"] = Color.FromArgb("#A8D4FF");
        //    Application.Current.Resources["PrimaryGradient"] = Color.FromArgb("#0080FF");
        //}
        //else
        //{
        //    Application.Current.Resources["PrimaryColor"] = Color.FromArgb("#2f72e4");
        //    Application.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#1a5ac6");
        //    Application.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#174fb0");
        //    Application.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#73a0ed");
        //    Application.Current.Resources["PrimaryLight"] = Color.FromArgb("#cdddf9");
        //    Application.Current.Resources["PrimaryGradient"] = Color.FromArgb("#00acff");
        //}

        Application.Current.Resources.TryGetValue("ThemePrimaryColorOption1", out var primaryColorOption1);

        Application.Current.Resources["PrimaryColor"] = (Color)primaryColorOption1;
        Application.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#1a5ac6");
        Application.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#174fb0");
        Application.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#73a0ed");
        Application.Current.Resources["PrimaryLight"] = Color.FromArgb("#cdddf9");
        Application.Current.Resources["PrimaryGradient"] = Color.FromArgb("#00acff");
    }

    public static void ApplyColorSet2()
    {
        //if (AppSettings.Instance.IsDarkTheme)
        //{
        //    Application.Current.Resources["PrimaryColor"] = Color.FromArgb("#D88AFF");
        //    Application.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#9E63BC");
        //    Application.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#804A9B");
        //    Application.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#D49FEE");
        //    Application.Current.Resources["PrimaryLight"] = Color.FromArgb("#D4B6E3");
        //    Application.Current.Resources["PrimaryGradient"] = Color.FromArgb("#6C58FF");
        //}
        //else
        //{
        //    Application.Current.Resources["PrimaryColor"] = Color.FromArgb("#5d4cf7");
        //    Application.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#4b3ae1");
        //    Application.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#3829ba");
        //    Application.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#b5aefb");
        //    Application.Current.Resources["PrimaryLight"] = Color.FromArgb("#eae8fe");
        //    Application.Current.Resources["PrimaryGradient"] = Color.FromArgb("#aa9cfc");
        //}

        Application.Current.Resources.TryGetValue("ThemePrimaryColorOption2", out var primaryColorOption2);

        Application.Current.Resources["PrimaryColor"] = (Color)primaryColorOption2;
        Application.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#4b3ae1");
        Application.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#3829ba");
        Application.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#b5aefb");
        Application.Current.Resources["PrimaryLight"] = Color.FromArgb("#eae8fe");
        Application.Current.Resources["PrimaryGradient"] = Color.FromArgb("#aa9cfc");
    }

    public static void ApplyColorSet3()
    {
        //if (AppSettings.Instance.IsDarkTheme)
        //{
        //    Application.Current.Resources["PrimaryColor"] = Color.FromArgb("#17B0A8");
        //    Application.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#11837D");
        //    Application.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#0B5652");
        //    Application.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#8AF0EA");
        //    Application.Current.Resources["PrimaryLight"] = Color.FromArgb("#CDF9F6");
        //    Application.Current.Resources["PrimaryGradient"] = Color.FromArgb("#A5FEB2");
        //}
        //else
        //{
        //    Application.Current.Resources["PrimaryColor"] = Color.FromArgb("#06846a");
        //    Application.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#056c56");
        //    Application.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#045343");
        //    Application.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#98f0de");
        //    Application.Current.Resources["PrimaryLight"] = Color.FromArgb("#ebf9f7");
        //    Application.Current.Resources["PrimaryGradient"] = Color.FromArgb("#0ed342");
        //}

        Application.Current.Resources.TryGetValue("ThemePrimaryColorOption3", out var primaryColorOption3);

        Application.Current.Resources["PrimaryColor"] = (Color)primaryColorOption3;
        Application.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#056c56");
        Application.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#045343");
        Application.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#98f0de");
        Application.Current.Resources["PrimaryLight"] = Color.FromArgb("#ebf9f7");
        Application.Current.Resources["PrimaryGradient"] = Color.FromArgb("#0ed342");
    }

    public static void ApplyColorSet4()
    {
        Application.Current.Resources.TryGetValue("ThemePrimaryColorOption4", out var primaryColorOption4);

        Application.Current.Resources["PrimaryColor"] = (Color)primaryColorOption4;
        Application.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#d0424f");
        Application.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#ab3641");
        Application.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#edcacd");
        Application.Current.Resources["PrimaryLight"] = Color.FromArgb("#ffe8f4");
        Application.Current.Resources["PrimaryGradient"] = Color.FromArgb("e83f94");
    }
    public static void ApplyColorSet5()
    {
        //if (AppSettings.Instance.IsDarkTheme)
        //{
        //    Application.Current.Resources["PrimaryColor"] = Color.FromArgb("#FF668C");
        //    Application.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#C83A62");
        //    Application.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#882742 ");
        //    Application.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#FF9FBA");
        //    Application.Current.Resources["PrimaryLight"] = Color.FromArgb("#FAC7D5");
        //    Application.Current.Resources["PrimaryGradient"] = Color.FromArgb("#FFBF9F");
        //}
        //else
        //{
        //    Application.Current.Resources["PrimaryColor"] = Color.FromArgb("#d54008");
        //    Application.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#a43106");
        //    Application.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#862805");
        //    Application.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#fa9e7c");
        //    Application.Current.Resources["PrimaryLight"] = Color.FromArgb("#fee7de");
        //    Application.Current.Resources["PrimaryGradient"] = Color.FromArgb("#ff6374");
        //}

        Application.Current.Resources.TryGetValue("ThemePrimaryColorOption5", out var primaryColorOption5);

        Application.Current.Resources["PrimaryColor"] = (Color)primaryColorOption5;
        Application.Current.Resources["PrimaryDarkColor"] = Color.FromArgb("#a43106");
        Application.Current.Resources["PrimaryDarkenColor"] = Color.FromArgb("#862805");
        Application.Current.Resources["PrimaryLighterColor"] = Color.FromArgb("#fa9e7c");
        Application.Current.Resources["PrimaryLight"] = Color.FromArgb("#fee7de");
        Application.Current.Resources["PrimaryGradient"] = Color.FromArgb("#ff6374");
    }
}
