using System;

namespace CandidateTesting.MarceloCosta.CreditSuisse.Helpers
{
  public static class ConsoleColorHelpers
  {
    // Black, DarkBlue, DarkGreen, DarkCyan, DarkRed, DarkMagenta, DarkYellow,
    // Gray, DarkGray, Blue, Green, Cyan, Red, Magenta, Yellow, White

    public static void Write(string text)
    {
      var foregroundColor = (int)Console.ForegroundColor;
      Console.Write(text);
      Console.ForegroundColor = (ConsoleColor)foregroundColor;
    }

    public static void Write(string text, ConsoleColor color)
    {
      var foregroundColor = (int)Console.ForegroundColor;
      Console.ForegroundColor = color;
      Console.Write(text);
      Console.ForegroundColor = (ConsoleColor)foregroundColor;
    }

    public static void Write(string text, ConsoleColor foreground, ConsoleColor background)
    {
      var backgroundColor = (int)Console.BackgroundColor;
      Console.BackgroundColor = background;
      Write(text, foreground);
      Console.BackgroundColor = (ConsoleColor)backgroundColor;
    }

    public static void Write(char character, ConsoleColor foreground, ConsoleColor background)
    {
      var foregroundColor = Console.ForegroundColor;
      var backgroundColor = (int)Console.BackgroundColor;
      Console.ForegroundColor = foreground;
      Console.BackgroundColor = background;
      Console.Write(character);
      Console.ForegroundColor = foregroundColor;
      Console.BackgroundColor = (ConsoleColor)backgroundColor;
    }

    public static void WriteLine(string text)
    {
      Write(text + Environment.NewLine);
    }

    public static void WriteLine(string text, ConsoleColor color)
    {
      Write(text + Environment.NewLine, color);
    }

    public static void WriteLine(string text, ConsoleColor foreground, ConsoleColor background)
    {
      Write(text + Environment.NewLine, foreground, background);
    }

    public static void Logger(string text, ConsoleColor color = ConsoleColor.White)
    {
      Write(text + Environment.NewLine + Environment.NewLine, color);
    }

  }
}