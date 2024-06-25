using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Создаем словарь для хранения информации о цветах
        var colors = new Dictionary<string, Dictionary<string, string>>
        {
            {
                "черный", new Dictionary<string, string>
                {
                    {"name", "black"},
                    {"rgb10", "rgb(0, 0, 0)"},
                    {"rgb16", "#000000"}
                }
            },
            {
                "серый", new Dictionary<string, string>
                {
                    {"name", "grey"},
                    {"rgb10", "rgb(128, 128, 128)"},
                    {"rgb16", "#808080"}
                }
            },
            {
                "белый", new Dictionary<string, string>
                {
                    {"name", "white"},
                    {"rgb10", "rgb(255, 255, 255)"},
                    {"rgb16", "#FFFFFF"}
                }
            }
        };

        // Получаем представление серого цвета
        var greyColor = colors["серый"];

        // Выводим представление серого цвета
        Console.WriteLine($"color: {greyColor["name"]};");
        Console.WriteLine($"color: {greyColor["rgb10"]};");
        Console.WriteLine($"color: {greyColor["rgb16"]};");
    }
}
