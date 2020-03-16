using System;
using System.Windows;

namespace StylesTemplatesSkinsThemes {
    public enum AppSkin {
        Default,
        Green
    }

    public static class SkinManager {
        public static AppSkin CurrentThemeType { get; private set; }

        public static void SetSkin(AppSkin appSkin) {
            CurrentThemeType = appSkin;
            Application.Current.Resources.MergedDictionaries[0].MergedDictionaries.Clear();
            var newDictionary = new ResourceDictionary();
            switch (appSkin) {
                case AppSkin.Default:
                    newDictionary.Source =
                        new Uri("pack://application:,,,/StylesTemplatesSkinsThemes;component/Skins/DefaultSkin.xaml");
                    break;
                case AppSkin.Green:
                    newDictionary.Source =
                        new Uri("pack://application:,,,/StylesTemplatesSkinsThemes;component/Skins/GreenSkin.xaml");
                    break;
            }
            Application.Current.Resources.MergedDictionaries[0].MergedDictionaries.Add(newDictionary);
        }
    }
}